using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gloria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Login.Text == "1111"||Password.Text=="1111" )
            {
                Form3 f = new Form3();
                f.Show();
            }
            if (Login.Text == "Admin" || Password.Text == "Admin")
            {
                Form4 f = new Form4();
                f.Show();
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            
            Password.PasswordChar= '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
