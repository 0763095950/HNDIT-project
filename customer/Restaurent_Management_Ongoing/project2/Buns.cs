﻿using System;
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
    public partial class Buns : UserControl
    {

        String itemCode;
        String orderNo = "";
        String tbleNo = "";
        public Buns(String orderNo, String tbleNo)
        {
            InitializeComponent();
            this.orderNo = orderNo;
            this.tbleNo = tbleNo;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            itemCode = "36";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            itemCode = "37";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            itemCode = "38";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            itemCode = "39";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            itemCode = "40";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            itemCode = "41";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            itemCode = "42";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            itemCode = "43";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            itemCode = "44";
            //ePrice = "100";
            Console.WriteLine("dessert tbl no " + tbleNo);
            new Order(itemCode, orderNo, tbleNo).Show();
        }

        private void Buns_Load(object sender, EventArgs e)
        {

        }
    }
}
