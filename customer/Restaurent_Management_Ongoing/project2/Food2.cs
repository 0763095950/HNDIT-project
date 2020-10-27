using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Food2 : UserControl
    {
        String itemCode;
        String orderNo = "";
        String tbleNo = "";
        public Food2(String orderNo, String tbleNo)
        {
            InitializeComponent();
            this.orderNo = orderNo;
            this.tbleNo = tbleNo;

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            itemCode = "19";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            itemCode = "20";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            itemCode = "21";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            itemCode = "22";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            itemCode = "23";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            itemCode = "24";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            itemCode = "25";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            itemCode = "26";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            itemCode = "27";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void Food2_Load(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
