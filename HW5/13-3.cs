using System;
using System.Drawing;
using System.Windows.Forms;



namespace _13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            a.BackColor = Color.Red;
            a.Text = "¬õ¿O";
            a.TextAlign = ContentAlignment.MiddleCenter;
            a.Dock = DockStyle.Fill;
        }

        private void a_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               a.BackColor = Color.Yellow;
               a.Text = "¶À¿O";
            }
            else if (e.Button == MouseButtons.Right)
            {
                a.BackColor = Color.Green;
                a.Text = "ºñ¿O";
            }
        }
    }
}
