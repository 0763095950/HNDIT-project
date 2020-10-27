using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cashier
{
    public partial class BillView : UserControl
    {
        public BillView()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            String orderNo = bunifuMaterialTextbox1.Text;

            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=restauretdb;uid=root;pwd=;";
            conn = new MySqlConnection(connetionString);
            String query;
            float total=0;


            query = "select * from orders_tb where orderNo='" + orderNo + "'";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    String item = rd["itemCode"].ToString();
                    String qty = rd["qty"].ToString();
                    String size = rd["size"].ToString();
                    String price = rd["total"].ToString();
                    total = total + float.Parse(price);
                    //lblTotal.Text = total.ToString();
                    //addItem(item, qty, size, price);



                }
                conn.Close();
                label1.Text = total.ToString() ;
            }
            catch(Exception ex)
            {
                Console.WriteLine("sad");
            }
        }
    }
}
