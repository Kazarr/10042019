using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Delete
    {
        private SqlConnection _connection;
        public Delete(SqlConnection connection)
        {
            _connection = connection;
        }
        public void ExecuteDelete(int id)
        {
            try
            {
                using (_connection)
                {
                    _connection.Open();
                    try
                    {
                        using(SqlCommand command = new SqlCommand())
                        {
                            command.Connection = _connection;
                            command.CommandText = "DELETE from Person.Person where BusinessEntityID = @Id";
                            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
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
