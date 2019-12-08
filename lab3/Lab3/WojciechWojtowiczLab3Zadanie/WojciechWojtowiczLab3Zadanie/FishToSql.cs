using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace WojciechWojtowiczLab3Zadanie
{
    class FishToSql
    {
        readonly Func<SqlConnection> dbConnection = () => new SqlConnection(ConfigurationManager.ConnectionStrings["FishingCentre"].ConnectionString);
        //instancja obiektu typu Fish
        Fish fish = null;
        //numer gracza
        int playerId;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="_fish"></param>
        /// <param name="_playerId"></param>
        public FishToSql(Fish _fish, int _playerId)
        {
            fish = _fish;
            playerId = _playerId;
        }

        /// <summary>
        /// funkcja dodaje do bazy danych złowioną rybę
        /// </summary>
        public void AddFishToSql()
        {
            // kwerenda do wysłania wraz z parametrami
            string query = "INSERT INTO [CatchedFish] ([FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (@Name, @Weight, @Lenght, @Protection, @UserId)";
            using (var connection = dbConnection())
            {
                connection.Open();
                // przekazanie z query do SqlCommand kwerendy
                SqlCommand queryString = new SqlCommand(query, connection);
                // przekazanie parametrów 
                queryString.Parameters.Add(new SqlParameter("@Name", fish.GetNameOfFish()));
                queryString.Parameters.Add(new SqlParameter("@Weight", fish.GetWeightOfFish()));
                queryString.Parameters.Add(new SqlParameter("@Lenght", fish.GetLenghtOfFich()));
                queryString.Parameters.Add(new SqlParameter("@Protection", fish.GetProtectiveLenght()));
                queryString.Parameters.Add(new SqlParameter("@UserId", playerId));
                queryString.ExecuteNonQuery();
            }
        }
    }
}
