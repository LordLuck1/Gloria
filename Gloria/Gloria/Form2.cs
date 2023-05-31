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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tovarBindingSource.Filter = null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gloriaDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.gloriaDataSet.Tovar);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tovarBindingSource.Filter = "Name=\'" + toolStripTextBox1.Text + ")";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(listBox1.SelectedValue) != "")
            {
                pictureBox1.ImageLocation = $"C:\\Users\\10\\Desktop\\Новая папка\\Gloria\\Gloria\\Resources\\{Convert.ToString(listBox1.SelectedValue)}";
                pictureBox1.Load();
            }
            else
            {
                pictureBox1.ImageLocation = "C:\\Users\\10\\Desktop\\Новая папка\\Gloria\\Gloria\\Resources\\picture.png";
                pictureBox1.Load();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
