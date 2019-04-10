using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Update
    {
        private SqlConnection _connection;

        public Update(SqlConnection connection)
        {
            _connection = connection;
        }

        public void ExecuteUpdate(int id, string firstName, string lastName)
        {
            try
            {
                using (_connection)
                {
                    _connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = _connection;
                            command.CommandText = "update Person.Person " +
                                                    "set FirstName = @Firstname, " +
                                                    "Lastname = @LastName " +
                                                    "where BusinessEntityID = @Id";
                            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                            command.Parameters.Add("@Firstname", SqlDbType.NVarChar).Value = firstName;
                            command.Parameters.Add("@Lastname", SqlDbType.NVarChar).Value = lastName;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch
                    {

                    }
                    
                }
            }
            catch
            {

            }
        }
    }
}
