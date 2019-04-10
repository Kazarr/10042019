using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MainForm
{
    public class InsertInto
    {
        private SqlConnection _connection;

        public InsertInto(SqlConnection connectionString)
        {
            _connection = connectionString;
        }
        public void ExecuteInsert(string firstName, string lastName)
        {
            using (_connection)
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = _connection;
                    command.CommandText = "insert into Person.BusinessEntity(rowguid, ModifiedDate) " +
                                            "output inserted.BusinessEntityID " +
                                            "values(newID(), GetDate())";
                    command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = _connection;
                    command.CommandText = "Insert into Person.Person (BusinessEntityID, PersonType, NameStyle, FirstName, LastName, EmailPromotion, rowguid, ModifiedDate)" +
                                                "Values (@Id, 'EM', 0, @FirstName, @LastName, 0, @Guid, @Date)";
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = GetId();
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName;
                    command.Parameters.Add("@Guid", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                    command.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateTime.Now;
                    bool succ = (command.ExecuteNonQuery() > 0);
                }
            }
        }
        private int GetId()
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _connection;
                command.CommandText = "Select Max(BusinessEntityID) from Person.Person";
                int maxId = (int)command.ExecuteScalar();
                return maxId + 1;
            }
        }
    }
}
