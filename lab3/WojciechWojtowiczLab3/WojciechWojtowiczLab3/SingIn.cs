using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WojciechWojtowiczLab3
{
    /// <summary>
    /// Klasa obsługująca logowanie do bazy danych
    /// </summary>
    class SignIn
    {
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Warehouse"].ConnectionString);
        public SqlCommand QuerySql { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        public SignIn(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Funkcja logująca do bazy danych
        /// </summary>
        /// <returns></returns>
        public bool SignInWarehouse()
        {
            int valueResult;
            bool isTrue = false;
            // kwerenda do wysłania wraz z parametrami
            string query = "SELECT COUNT(UserName) FROM UserLogin WHERE UserName = @Username AND Password = @Password";
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                // przekazanie z query do SqlCommand kwerendy
                QuerySql = new SqlCommand(query, connection);
                // przekazanie parametrów 
                QuerySql.Parameters.Add(new SqlParameter("@Username", Username));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                valueResult = (int)QuerySql.ExecuteScalar(); // wynik próby połączenia

                // jesli się udało
                if (valueResult >= 1)
                {
                    isTrue = true;
                }
            }
            return isTrue;
        }
    }
}
