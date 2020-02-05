using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A.3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-OISLER2\\WOJTEKSQL;Database=NORTHWND;Trusted_Connection=True;";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employees", con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                
                dataGridView1.DataSource = table;
            }


            con.Close();
        }

        /// <summary>
        /// A.4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-OISLER2\\WOJTEKSQL;Database=NORTHWND;Trusted_Connection=True;";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products", con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }


            con.Close();
        }
    }
}
