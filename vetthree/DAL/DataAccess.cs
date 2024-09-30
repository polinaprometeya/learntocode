using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DAL;

public class DataAccess
{
    //public string ConfigureServices()
    //{
    //    string ConnectionString =
    //        "Data Source=localhost;"+
    //        "Initial Catalog=sustainmeasure;"+
    //        "User id=sa;"+
    //        "Password=Secret;";

    //    //string ConnectionString = "Server=localhost;Database=sustainmeasure;User=sa;Password=f9Ett?FnLdqfE.docker;";

    //    //_ = new ConfigurationBuilder().AddJsonFile("appsettings.json")
    //    //   .AddEnvironmentVariables().Build();
    //    return ConnectionString;
    //}



    public List<Patient> getData()
    {
        List<Patient> patientData = new List<Patient>();

        string ConnectionString = "Server=localhost;Database=sustainmeasure;User=sa;Password=f9Ett?FnLdqfE.docker;Encrypt=False;";
        //string ConnectionString = "DefaultConnection = Data Source=model-e39f7674-4c78-453c-94a4-4b39fbd9da76.db";
        using (SqlConnection conn = new SqlConnection(

    //    new SqlConnectionStringBuilder() { DataSource = "localhost", InitialCatalog = "sustainmeasure",UserID = "sa", Password = "f9Ett?FnLdqfE.docker",}.ConnectionString

        ConnectionString
        ))
        {
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT id_animal, name_animal, date_birth, type_animal, id_customer FROM animal";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    SqlDataReader sqlData = cmd.ExecuteReader();

                    while (sqlData.Read()) {
                        patientData.Add(new Patient
                        {
                            id_animal = sqlData.GetInt32(0),
                            name_animal = sqlData.GetString(2),
                            date_birth = sqlData.GetDateTime(3),
                            type_animal = sqlData.GetString(4),
                            id_customer = sqlData.GetInt32(1),
                        });
                        Console.WriteLine(conn);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            conn.Close();
            return patientData;
        }

    }

}

