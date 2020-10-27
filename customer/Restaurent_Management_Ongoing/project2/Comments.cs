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
    public partial class Comments : Form
    {
        public Comments()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Comments_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuRating1_onValueChanged(object sender, EventArgs e)
        {
            if (bunifuRating1.Value ==  1)
            {
                label5.Text = Convert.ToString(1);
                string rateval = label5.Text;
            }
            if (bunifuRating1.Value == 2)
            {
                label5.Text = Convert.ToString(2);
                string rateval = label5.Text;
            }
            if (bunifuRating1.Value == 3)
            {
                label5.Text = Convert.ToString(3);
                string rateval = label5.Text;
            }
            if (bunifuRating1.Value == 4)
            {
                label5.Text = Convert.ToString(4);
                string rateval = label5.Text;
            }
            if (bunifuRating1.Value == 5)
            {
                label5.Text = Convert.ToString(5);
                string rateval = label5.Text;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string comment = textBox3.Text;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Mobile = textBox2.Text;
        }

        
      
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

               
                string rateval = label5.Text;
               
                MySqlDataReader rd;

                MySqlConnection conn;
                string connetionString = null;
                connetionString = "server=localhost;database=csharpp;uid=root;pwd=;";
                conn = new MySqlConnection(connetionString);
                String query;
                query = "insert into restauretdb. comment_tb3(mobile,name,rateval,comments)VALUES('" + textBox2.Text + "','" + textBox1.Text + "','" + rateval + "','" + textBox3.Text + "')";

                MySqlCommand command = new MySqlCommand(query, conn);

                try
                {

                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Plase enter Mobile Number");
                    }
                    else
                    {


                        conn.Open();
                        rd = command.ExecuteReader();
                        MessageBox.Show("Thanks For Rate Us");
                        conn.Close();
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(" Can't Add because:- " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    textBox2.Text = textBox1.Text =  textBox3.Text = label5.Text =  "";
                }
            

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = localhost; Initial Catalog = 'restauretdb'; username = root; password=");
            MySqlCommand command;
            MySqlDataAdapter adapter;
            DataTable table;
            string query = "SELECT * FROM  restauretdb.comment_tb3  ";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

      
        

       

       
    }
}
