using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        string name;
        string firsName;
        string lastName;
        string phone;
        string email;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firsName = textBox1.Text;
            name = textBox2.Text;
            lastName = textBox3.Text;
            phone = textBox4.Text;
            email = textBox5.Text;
            if(phone.Length == 0 && email.Length == 0)
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
                this.Close();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
