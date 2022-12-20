using System.Data;
using System.Data.SqlClient;

namespace ADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=ALI\\SQLEXPRESS;Database=Spotify; Trusted_Connection= True";


            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{

            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("INSERT INTO Musics VALUES (N'Bu seher Evimdir' ,'3:51',1,NULL)",connection))
            //    {
            //        command.ExecuteNonQuery();
            //    }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlDataAdapter sda= new SqlDataAdapter("SELECT * FROM Musics",connection))
                {
                    DataTable dt = new DataTable();
                        sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine(dr["MusicName"]);
                        Console.WriteLine(dr["ID"]);
                        Console.WriteLine(dr["Duration"]);
                    }
                }

            }
        }
    }
    
}