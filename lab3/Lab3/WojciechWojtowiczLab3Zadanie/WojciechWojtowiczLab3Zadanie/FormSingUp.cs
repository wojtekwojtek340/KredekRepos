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
    public partial class FormSingUp : Form
    {
        readonly Func<SqlConnection> connectionFishingCentre = () => new SqlConnection(ConfigurationManager.ConnectionStrings["FishingCentre"].ConnectionString);

        /// <summary>
        /// konstruktor
        /// </summary>
        public FormSingUp()
        {
            InitializeComponent();
            GetDataFromTabele();
        }

        /// <summary>
        /// funckja wyświetlajaca dane w tabeli
        /// </summary>
        public void GetDataFromTabele()
        {
            using (var connection = connectionFishingCentre())
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT UserId, UserName FROM Users", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewUsers.DataSource = table;
                }
            }
        }

        /// <summary>
        /// funckja dodająca nowego użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            try
            {
                SingUp singUp = new SingUp(textBoxUserName.Text, textBoxUserPassword.Text);
                singUp.SingUpFishingCentre();
                GetDataFromTabele();
                MessageBox.Show("Zarejestrowany pomyślnie!");
                this.Close();
            }
            catch (ArgumentException exception)
            {
                textBoxUserName.Clear();
                textBoxUserPassword.Clear();
                MessageBox.Show(exception.Message);
            }
        }
    }
}
