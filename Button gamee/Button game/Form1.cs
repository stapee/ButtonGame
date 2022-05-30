using System;
using System.Drawing;

namespace Button_game
{
    public partial class MainForm : FormWithoutTitle
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text))
            {
                label3.ForeColor = Color.Red;
                return;
            }

            State.Name = nameBox.Text;
            Hide();

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e) => Program.Close();
    }
}
