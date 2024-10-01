using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DAL;

public class DataAccess
{
    //public string ConfigureServices()
    //{
    //    new SqlConnectionStringBuilder() { DataSource = "**", InitialCatalog = "**",UserID = "**", Password = "**",}.ConnectionString

    //string ConnectionString = "DefaultConnection = Data Source=model-e39f7674-4c78-453c-94a4-4b39fbd9da76.db";

    //    string ConnectionString =
    //        "Data Source=**;"+
    //        "Initial Catalog=**;"+
    //        "User id=sa;"+
    //        "Password=Secret;";

    //    //string ConnectionString = "Server=**;Database=**;User=**;Password=**;";

    //    //_ = new ConfigurationBuilder().AddJsonFile("appsettings.json")
    //    //   .AddEnvironmentVariables().Build();
    //    return ConnectionString;
    //}

    public List<Patient> getData()
    {
        List<Patient> patientData = new List<Patient>();

        string ConnectionString = "Server=**;Database=**;User=**;Password=**;Encrypt=False;";

        using (SqlConnection conn = new SqlConnection(ConnectionString))
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
                            name_animal = sqlData.GetString(1),
                            date_birth = (DateTime)sqlData.GetSqlDateTime(2),
                            type_animal = sqlData.GetString(3),
                            id_customer = sqlData.GetInt32(4),
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

