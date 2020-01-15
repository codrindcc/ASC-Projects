using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s = 0;
        int change_nikel = 0;
        int change_dime = 0;
        bool hasproduct = false;
        int product_count = 0;

        public void main_function(int value, string msg)
        {
            if (s < 20 && !hasproduct)
            {
                s += value;
                display.Text = s.ToString();
                listBox1.Items.Add(msg + " was inserted : credit = " + s);
            }
            if (s >= 20)
            {
                s -= 20;
                display.Text = s.ToString();
                panel1.Visible = true;

                change_dime = s / 10;
                s = s % 10;
                change_nikel = s / 5;
                label1.Text = change_dime.ToString();
                label2.Text = change_nikel.ToString();
                hasproduct = true;
            }
            if (hasproduct)
                listBox1.Items.Add("Please remove product");
        }
        private void btn_add_5_Click(object sender, EventArgs e)
        {
            main_function(5, "NIKEL");
        }

        private void btn_add_10_Click(object sender, EventArgs e)
        {
            main_function(10, "DIME");
        }

        private void btn_add_25_Click(object sender, EventArgs e)
        {
            main_function(25, "QUARTER");
        }

        public void reset(string msg) 
        {
            s = 0;
            panel1.Visible = false;
            display.Text = s.ToString();
            hasproduct = false;
            product_count++;
            listBox1.Items.Add(msg + " removed");
            listBox1.Items.Add(product_count + " solded this sesion");
            if (change_nikel == 1)
                listBox1.Items.Add("Nickel was delivered");

            if (change_dime != 0)
            {
                for (int i = 0; i < change_dime; i++)
                    listBox1.Items.Add("Dime was delivered");
            }

        }

        private void btn_take_Click(object sender, EventArgs e)
        {
            reset("COFFE");           

        }

        private void btn_add_100_Click(object sender, EventArgs e)
        {
            main_function(100, "DOLLAR");
        }

        private void btn_Take_capuccino_Click(object sender, EventArgs e)
        {
            reset("CAPUCCINO");
        }
    }
}
