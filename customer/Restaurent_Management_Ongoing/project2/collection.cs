using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project2
{
    public partial class collection : Form
    {
        public collection()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = localhost; Initial Catalog = 'restauretdb'; username = root; password=");
            MySqlCommand command;
            MySqlDataAdapter adapter;
            DataTable table;
            string query = "SELECT * FROM  restauretdb.itemlist_tb where itemCode ";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}

















