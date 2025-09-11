using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dacuma
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

            string myUsername = "Helman";
            string myPassword = "admin123";

            if (Username == "" || Password == "")
            {
                MessageBox.Show("Empty Fields");
                return; 
            }

            if (myUsername == Username && myPassword == Password)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;

                Form2 main = new Form2();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mali Takti");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
