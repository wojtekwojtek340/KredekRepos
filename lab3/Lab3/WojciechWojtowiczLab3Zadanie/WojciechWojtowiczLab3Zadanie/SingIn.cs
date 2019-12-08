using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WojciechWojtowiczLab3Zadanie
{
    /// <summary>
    /// klasa obsługuje logowanie
    /// </summary>
    class SingIn
    {
        readonly Func<SqlConnection> dbConnection = () => new SqlConnection(ConfigurationManager.ConnectionStrings["FishingCentre"].ConnectionString);
        //nazwa
        string username;
        //haslo
        string password;
        // instancja obiektu typu Player
        Player player = null;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="_username"></param>
        /// <param name="_password"></param>
        /// <param name="_player"></param>
        public SingIn(string _username, string _password, Player _player)
        {
            username = _username;
            password = _password;
            player = _player;
        }

        /// <summary>
        /// metoda odpowiedzialna jest za logowanie
        /// </summary>
        public void SingInFishingCentre()
        {
            string query = "SELECT COUNT(UserName) FROM Users WHERE UserName = @UserName AND UserPassword = @UserPassword";
            string query2 = "SELECT UserId FROM Users WHERE UserName = '" + username + "'";

            using (var connection = dbConnection())
            {
                connection.Open();
                SqlCommand queryString = new SqlCommand(query, connection);
                queryString.Parameters.Add(new SqlParameter("@UserName", username));
                queryString.Parameters.Add(new SqlParameter("@UserPassword", password));
                int valueResult = (int)queryString.ExecuteScalar();
                if (valueResult >= 1)
                {
                    queryString = new SqlCommand(query2, connection);
                    using (SqlDataReader reader = queryString.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            player.SetUserId(userId);
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Błędny login lub hasło!");
                }
            }
        }
    }
}
