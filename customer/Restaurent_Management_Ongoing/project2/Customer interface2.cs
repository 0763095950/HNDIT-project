using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGetTableNo P = new frmGetTableNo();
            P.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Takeaway t = new Takeaway();
            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            collection Collec = new collection();
            Collec.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comments C = new Comments();
            C.Show();
            this.Hide();
           
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
