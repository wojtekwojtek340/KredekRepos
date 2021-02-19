using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WojciechWojtowiczLab7Zadanie.Models;

namespace WojciechWojtowiczLab7Zadanie.Service
{
    public class CakeService
    {
        //lista ciast
        public static List<Cake> cakes = new List<Cake>();
        //connection string
        string connectionString = "Server=DESKTOP-TH6F0L5;Database=Restaurant;Trusted_Connection=True;";

        /// <summary>
        /// konstruktor
        /// </summary>
        public CakeService()
        {
            if(cakes.Count == 0)
            {
                GetData();
            }            
        }

        /// <summary>
        /// pobranie danych z bazy danych
        /// </summary>
        public void GetData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            cakes.Clear();
            connection.Open();

            SqlCommand com = new SqlCommand("Select * FROM Cakes", connection);

            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {
                    Cake cake = new Cake();

                    cake.Id = (int)reader[0];
                    cake.Name = (string)reader[1];
                    cake.Description = (string)reader[2];
                    cake.Cost = (decimal)reader[3];

                    cakes.Add(cake);
                }
            }
            connection.Close();
        }

        /// <summary>
        /// zwrócenie listy ciast
        /// </summary>
        /// <returns></returns>
        public List<Cake> Get()
        {
            GetData();
            return cakes;
        }

        /// <summary>
        /// dodanie ciast do bazy danych
        /// </summary>
        /// <param name="cake"></param>
        /// <returns></returns>
        public int Post(Cake cake)
        {           

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Cakes (Name, Description, Cost) VALUES (@Name, @Description, @Cost)", connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", cake.Name);
            cmd.Parameters.AddWithValue("@Description", cake.Description);
            cmd.Parameters.AddWithValue("@Cost", cake.Cost);
            cmd.ExecuteNonQuery();
            connection.Close();

            int id;

            GetData();
            id = cakes.Max(x => x.Id);

            return id;
        }

        /// <summary>
        /// edycja ciasta w bazie danych
        /// </summary>
        /// <param name="cake"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Put(Cake cake, int Id)
        {
            var cakeToUpdate = cakes.Where(x => x.Id.Equals(Id)).Single();
            cakeToUpdate.Name = cake.Name;
            cakeToUpdate.Description = cake.Description;
            cakeToUpdate.Cost = cake.Cost;

            string query = "UPDATE Cakes SET Name = @Name, ";
            string query2 = "Description = @Description, ";
            string query3 = "Cost = @Cost WHERE Id=" + Id;
            string queeryAll = query + query2 + query3;

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand cmd = new SqlCommand(queeryAll, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", cake.Name);
            cmd.Parameters.AddWithValue("@Description", cake.Description);
            cmd.Parameters.AddWithValue("@Cost", cake.Cost);
            cmd.ExecuteNonQuery();
            connection.Close();

            return true;
        }

        /// <summary>
        /// usuniecie ciasta z bazy danych
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            var cake = cakes.Where(x => x.Id.Equals(Id)).SingleOrDefault();            
            if (cake == null)
            {
                return false;

            }
            else
            {
                cakes.Remove(cake);

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Cakes WHERE Id=" + Id, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                }
                connection.Close();

                return true;
            }
        }
    }
}
