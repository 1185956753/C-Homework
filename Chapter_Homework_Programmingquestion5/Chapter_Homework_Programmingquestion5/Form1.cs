﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_Homework_Programmingquestion5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            double d1 = double.Parse(s1);
            double d2 = double.Parse(s2);
            double product = d1 * d2;
            label2.Text = d1 + "和" + d2 + "的乘积为：" + product;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
