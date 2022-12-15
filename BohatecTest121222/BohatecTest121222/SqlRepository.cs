using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BohatecTest121222
{
    public class SqlRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BohatecTest121222;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT * FROM Employee";
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                var employee = new Employee()
                                {
                                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                                    Firstname = sqlDataReader["Firstname"].ToString(),
                                    Lastname = sqlDataReader["Lastname"].ToString(),
                                    Email = sqlDataReader["Email"].ToString(),
                                    Phone = sqlDataReader["Phone"].ToString(),
                                    Birthday = Convert.ToDateTime(sqlDataReader["Birthday"])
                                };
                                employees.Add(employee);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error (Exception: {ex.Message})");
            }
            return employees;
        }
        public void DeleteSelectedEmployee(string idValue)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "DELETE FROM Employee WHERE Id=@id";
                        sqlCommand.Parameters.AddWithValue("@id", idValue);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error (Exception: {ex.Message})");
            }
        }
        public void AddNewRecord(string firstname, string lastname, string email, string phone, DateTime birthday)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "INSERT INTO Employee (Firstname, Lastname, Email, Phone, Birthday) VALUES (@firstname,@lastname,@email,@phone, @birthday)";
                        
                        sqlCommand.Parameters.AddWithValue("@firstname", firstname);
                        sqlCommand.Parameters.AddWithValue("@lastname", lastname);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@phone", phone);
                        sqlCommand.Parameters.AddWithValue("@birthday", birthday);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error (Exception: {ex.Message})");
            }
        }
        public void EditExistingRecord(string id, string firstname, string lastname, string email, string phone, DateTime birthday)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "UPDATE Employee SET Firstname=@firstname, Lastname=@lastname, Email=@email, Phone=@phone, Birthday=@birthday WHERE  Id=@id ";
                       
                        sqlCommand.Parameters.AddWithValue("@id", id);
                        sqlCommand.Parameters.AddWithValue("@firstname", firstname);
                        sqlCommand.Parameters.AddWithValue("@lastname", lastname);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@phone", phone);
                        sqlCommand.Parameters.AddWithValue("@birthday", birthday);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error (Exception: {ex.Message})");
            }
        }
    }
}
