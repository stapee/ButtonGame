using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Button_game
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label3.ForeColor = Color.Red;
                return;
            }
            else
            {
                MyData.n = textBox1.Text;
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public static class MyData
    {
        public static string n;
    }
}
