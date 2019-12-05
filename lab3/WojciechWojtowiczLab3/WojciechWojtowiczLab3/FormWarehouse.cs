using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WojciechWojtowiczLab3
{
    public partial class FormWarehouse : Form
    {
        /// <summary>
        /// Configuration Manager potrzebuje dodania do referencji biblioteki System.Configuration
        /// </summary>
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Warehouse"].ConnectionString);
        public FormWarehouse()
        {
            InitializeComponent();
            GetDataFromTable();
        }

        /// <summary>
        /// Metoda połączy dane z dataGridView 
        /// </summary>
        public void GetDataFromTable()
        {
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                // adapter
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM UserLogin", connection))
                {
                    DataTable table = new DataTable(); // tworzenie tabeli
                    adapter.Fill(table); // wynik zapytania do tabeli
                    // Do datagridview dodano powyższą tabelę
                    dataGridViewWarehouse.DataSource = table;
                }
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                // adapter
                // pokazuje pozycje z username "Adam" - mozna sparametryzowac tak jak w SignIn
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + textBoxFilter.Text, connection))
                {

                    DataTable table = new DataTable(); // tworzenie tabeli
                    adapter.Fill(table); // wynik zapytania do tabeli
                    // Do datagridview dodano powyższą tabelę
                    dataGridViewWarehouse.DataSource = table;
                }
            }
        }
    }
}
