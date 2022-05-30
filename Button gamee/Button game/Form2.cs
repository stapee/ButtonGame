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
    public partial class Form2 : Form
    {
        public int a = 0;
        public Form2()
        {
            InitializeComponent();
            label1.Text = MyData.n + " : 0";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x, y, c;
            x = rnd.Next(10, 600);
            y = rnd.Next(0, 370);
            c = rnd.Next(0, 10);
            button1.Location = new Point(x, y);
            button1.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            a += 1;
            label1.Text = MyData.n + " : " + a;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
