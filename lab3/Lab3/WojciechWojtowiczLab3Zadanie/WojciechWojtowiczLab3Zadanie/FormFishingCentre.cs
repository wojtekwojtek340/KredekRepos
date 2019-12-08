using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WojciechWojtowiczLab3Zadanie
{
    public partial class FormFishingCentre : Form
    {
        readonly Func<SqlConnection> connectionFishingCentre = () => new SqlConnection(ConfigurationManager.ConnectionStrings["FishingCentre"].ConnectionString);
        // wiersz z datagridview
        DataGridViewRow row = null;
        //numer gracza
        int userId;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="_userId"></param>
        public FormFishingCentre(int _userId)
        {
            userId = _userId;
            InitializeComponent();
            GetDataFromTabele();
        }

        /// <summary>
        /// funkcja wyświetlająca dane w tabeli
        /// </summary>
        public void GetDataFromTabele()
        {
            using (var connection = connectionFishingCentre())
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CatchedFish", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewFishes.DataSource = table;
                }
            }
        }

        /// <summary>
        /// funkcja dodająca wiersz do tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [CatchedFish] ([FishName], [FishWeight], [FishLenght], [FishProtectionLenght], [UserId]) VALUES (@FishName, @FishWeight, @FishLenght, @FishProtectionLenght, @UserId)";

            if (userId != 0)
            {
                using (var connection = connectionFishingCentre())
                {
                    connection.Open();
                    SqlCommand queryString = new SqlCommand(query, connection);
                    queryString.Parameters.Add(new SqlParameter("@FishName", textBoxName.Text));
                    queryString.Parameters.Add(new SqlParameter("@FishWeight", textBoxWeight.Text));
                    queryString.Parameters.Add(new SqlParameter("@FishLenght", textBoxLenght.Text));
                    queryString.Parameters.Add(new SqlParameter("@FishProtectionLenght", textBoxProtectionLenght.Text));
                    queryString.Parameters.Add(new SqlParameter("@UserId", userId));
                    queryString.ExecuteNonQuery();
                    GetDataFromTabele();
                }
            }
            else
            {
                MessageBox.Show("Musisz się zalogować!");
            }

        }

        /// <summary>
        /// funkcja edytująca wybrany wiersz z tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(row != null)
            {
                string query = "UPDATE CatchedFish SET FishName = @FishName, ";
                string query2 = "FishWeight = @FishWeight, ";
                string query3 = "FishLenght = @FishLenght, ";
                string query4 = "FishProtectionLenght = @FishProtectionLenght WHERE FishId = " + row.Cells["FishId"].Value;
                string queerytest = query + query2 + query3 + query4;
                using (var connection = connectionFishingCentre())
                {
                    connection.Open();
                    SqlCommand queryString = new SqlCommand(queerytest, connection);
                    queryString.Parameters.Add(new SqlParameter("@FishName", textBoxName.Text));
                    queryString.Parameters.Add(new SqlParameter("@FishWeight", textBoxWeight.Text));
                    queryString.Parameters.Add(new SqlParameter("@FishLenght", textBoxLenght.Text));
                    queryString.Parameters.Add(new SqlParameter("@FishProtectionLenght", textBoxProtectionLenght.Text));
                    queryString.ExecuteNonQuery();
                    GetDataFromTabele();
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć wiersz!");
            }
        }

        /// <summary>
        /// funkcja usuwająca wybrany wiersz z tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(row != null)
            {
                using (var connection = connectionFishingCentre())
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM CatchedFish WHERE FishId = '" + row.Cells["FishId"].Value + "'", connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewFishes.DataSource = table;
                        GetDataFromTabele();
                    }
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć wiersz!");
            }
        }

        /// <summary>
        /// funckja wyświetla w textboxach dane z wybranego wiersza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewFishes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = this.dataGridViewFishes.Rows[e.RowIndex];
                int fishId = Int32.Parse(row.Cells["FishId"].Value.ToString());
                textBoxName.Text = row.Cells["FishName"].Value.ToString();
                textBoxWeight.Text = row.Cells["FishWeight"].Value.ToString();
                textBoxLenght.Text = row.Cells["FishLenght"].Value.ToString();
                textBoxProtectionLenght.Text = row.Cells["FishProtectionLenght"].Value.ToString();
            }
        }

        /// <summary>
        /// funckja czyszcząca wybrany wiersz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                string query = "UPDATE CatchedFish SET FishName = @FishName, ";
                string query2 = "FishWeight = @FishWeight, ";
                string query3 = "FishLenght = @FishLenght, ";
                string query4 = "FishProtectionLenght = @FishProtectionLenght WHERE FishId = " + row.Cells["FishId"].Value;
                string queerytest = query + query2 + query3 + query4;
                using (var connection = connectionFishingCentre())
                {
                    connection.Open();
                    SqlCommand queryString = new SqlCommand(queerytest, connection);
                    queryString.Parameters.Add(new SqlParameter("@FishName", ""));
                    queryString.Parameters.Add(new SqlParameter("@FishWeight", ""));
                    queryString.Parameters.Add(new SqlParameter("@FishLenght", ""));
                    queryString.Parameters.Add(new SqlParameter("@FishProtectionLenght", ""));
                    queryString.ExecuteNonQuery();
                    GetDataFromTabele();
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć wiersz!");
            }          
        }

        /// <summary>
        /// checkbox pokazujacy w tabeli ryby złowone na zalogowanym koncie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxMyFishes_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMyFishes.Checked == true)
            {
                using (var connection = connectionFishingCentre())
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CatchedFish WHERE UserId = '" + userId + "'", connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewFishes.DataSource = table;
                    }
                }
            }
            else
            {
                using (var connection = connectionFishingCentre())
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CatchedFish", connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewFishes.DataSource = table;
                    }
                }
            }
        }
    }
}
