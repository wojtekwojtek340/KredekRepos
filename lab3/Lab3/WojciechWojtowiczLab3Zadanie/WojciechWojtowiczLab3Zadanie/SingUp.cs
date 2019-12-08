using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WojciechWojtowiczLab3Zadanie
{
    /// <summary>
    /// klasa obslugujaca rejestracje
    /// </summary>
    class SingUp
    {
        readonly Func<SqlConnection> dbConnection = () => new SqlConnection(ConfigurationManager.ConnectionStrings["FishingCentre"].ConnectionString);
        //nazwa
        string username;
        //haslo
        string password;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="_username"></param>
        /// <param name="_password"></param>
        public SingUp(string _username, string _password)
        {
            if (_username.Length < 30 && _password.Length < 30)
            {
                username = _username;
                password = _password;
            }
            else
            {
                throw new ArgumentException("Za długa nazwa lub hasło");
            }
        }

        /// <summary>
        /// metoda odpowiedzialna za rejestracje uzytkowniak
        /// </summary>
        public void SingUpFishingCentre()
        {
            string query = "INSERT INTO Users (UserName, UserPassword) VALUES (@UserName, @UserPassword)";

            using (var connection = dbConnection())
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT UserName FROM Users WHERE UserName = '" + username + "'", connection))
                {
                    DataTable table = new DataTable();
                    if (adapter.Fill(table) != 0)
                    {
                        throw new ArgumentException("Taka nazwa użytkownika już istnieje!");
                    }
                }

                SqlCommand queryString = new SqlCommand(query, connection);
                queryString.Parameters.Add(new SqlParameter("@UserName", username));
                queryString.Parameters.Add(new SqlParameter("@UserPassword", password));
                queryString.ExecuteNonQuery();
            }
        }
    }
}
