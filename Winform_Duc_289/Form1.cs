using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DLL;
namespace Winform_Duc_289
{
    public partial class Form1 : Form
    {
        private Class1 storyGen;

        public Form1()
        {
            InitializeComponent();
            storyGen = new Class1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string k1 = txtKeyword1.Text.Trim();
            string k2 = txtKeyword2.Text.Trim();
            string k3 = txtKeyword3.Text.Trim();

            if (string.IsNullOrEmpty(k1) || string.IsNullOrEmpty(k2) || string.IsNullOrEmpty(k3))
            {
                MessageBox.Show("Vui lòng nhập đủ 3 keyword!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string story = storyGen.GenerateStory(k1, k2, k3);
            txtResult.Text = story;
        }
    }
}
