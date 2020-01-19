using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WojciechWojtowiczLab7Zadanie.Models;

namespace WojciechWojtowiczLab7Zadanie.Service
{
    public class CoffeeService
    {
        //lista kaw
        public static List<Coffee> coffees = new List<Coffee>();
        //connection string
        string connectionString = "Server=WOJTEKPC\\WOJTEKSQL;Database=Restaurant;Trusted_Connection=True;";

        /// <summary>
        /// konstruktor
        /// </summary>
        public CoffeeService()
        {
            if(coffees.Count == 0)
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
            coffees.Clear();
            connection.Open();

            SqlCommand com = new SqlCommand("Select * FROM Coffee", connection);

            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {
                    Coffee coffee = new Coffee();

                    coffee.Id = (int)reader[0];
                    coffee.Name = (string)reader[1];
                    coffee.Description = (string)reader[2];
                    coffee.Cost = (decimal)reader[3];

                    coffees.Add(coffee);
                }
            }
            connection.Close();
        }

        /// <summary>
        /// zwrócenie listy kaw
        /// </summary>
        /// <returns></returns>
        public List<Coffee> Get()
        {
            GetData();
            return coffees;
        }

        /// <summary>
        /// dodanie kawy do bazy
        /// </summary>
        /// <param name="coffee"></param>
        /// <returns></returns>
        public int Post(Coffee coffee)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Coffee (Name, Description, Cost) VALUES (@Name, @Description, @Cost)",connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", coffee.Name);
            cmd.Parameters.AddWithValue("@Description", coffee.Description);
            cmd.Parameters.AddWithValue("@Cost", coffee.Cost);
            cmd.ExecuteNonQuery();
            connection.Close();

            int id;

            GetData();
            id = coffees.Max(x => x.Id);            

            return id;
        }

        /// <summary>
        /// edycja kawy w bazie
        /// </summary>
        /// <param name="coffee"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Put(Coffee coffee, int Id)
        {
            var coffeeToUpdate = coffees.Where(x => x.Id.Equals(Id)).Single();
            coffeeToUpdate.Name = coffee.Name;
            coffeeToUpdate.Description = coffee.Description;
            coffeeToUpdate.Cost = coffee.Cost;

            string query = "UPDATE Coffee SET Name = @Name, ";
            string query2 = "Description = @Description, ";
            string query3 = "Cost = @Cost WHERE Id="+Id;
            string queerytest = query + query2 + query3;

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand cmd = new SqlCommand(queerytest, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", coffee.Name);
            cmd.Parameters.AddWithValue("@Description", coffee.Description);
            cmd.Parameters.AddWithValue("@Cost", coffee.Cost);
            cmd.ExecuteNonQuery();
            connection.Close();


            return true;
        }

        /// <summary>
        /// usuniecia kawy z bazy
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            var coffee = coffees.Where(x => x.Id.Equals(Id)).SingleOrDefault();
            if (coffee == null)
            {
                return false;

            }
            else
            {
                coffees.Remove(coffee);

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Coffee WHERE Id="+ Id, connection))
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
