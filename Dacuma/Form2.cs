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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OpenChild(new DashboardForm());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void OpenChild(Form childForm)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChild(new DashboardForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChild(new UserManagerForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChild(new ChatBotForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChild(new FaceRecognitionForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChild(new SettingsForm());
        }
    }
}
