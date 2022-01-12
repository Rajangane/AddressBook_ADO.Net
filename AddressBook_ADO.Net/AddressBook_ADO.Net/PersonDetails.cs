using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_ADO.Net
{
    public class PersonDetails
    {
       // public static string connectionString = (@"Data (localdb)\MSSQLLocalDB;Initial Catalog=AddressBookSystem;Integrated Security=True;");
        //SqlConnection connection = new SqlConnection(connectionString);
        public static string connectionString = @"Data source=(localdb)\MSSQLLocalDB; Initial Catalog=AddressBookSystem; Integrated Security=True;";
        SqlConnection connection = new SqlConnection(connectionString);

        public bool AddEmployee(Person model)
        {
            try
            {
                using (this.connection)
                {
                    this.connection.Open();
                    SqlCommand command = new SqlCommand("SpAddPersonDetail", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", model.ID);
                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@zip", model.zip);
                    command.Parameters.AddWithValue("@City", model.City);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@Email", model.Email);
                    command.Parameters.AddWithValue("@AddressBookName", model.AddressBookName);
                    command.Parameters.AddWithValue("@Type", model.Type);

                    var result = command.ExecuteNonQuery();
                    // this.connection.Close();
                    if (result != 0)
                    {

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
    }
}
