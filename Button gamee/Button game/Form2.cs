using System;
using System.Drawing;
using System.Windows.Forms;

namespace Button_game
{
    public partial class Form2 : FormWithoutTitle
    {
        public int Count = 0;
        public Form2()
        {
            InitializeComponent();
            RenderCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            button1.Location = GetRandomPosition();
            button1.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));

            Count++;

            RenderCount();
        }

        private Point GetRandomPosition()
        {
            Random random = new Random();

            return new Point(random.Next(10, 600), random.Next(0, 370));
        }

        private void RenderCount() => label1.Text = $"{State.Name}: {Count}";

        private void button2_Click(object sender, EventArgs e) => Program.Close();
    }
}
