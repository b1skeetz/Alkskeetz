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
    public partial class Form3 : Form
    {
        string name;
        string firsName;
        string lastName;
        string doly;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //сделай подтверждение (регистрация прошла успешно) и только потом закрытие приложения через 2 сек (2000мс) 
            firsName = textBox1.Text;
            name = textBox2.Text;
            lastName = textBox3.Text;
            doly = textBox4.Text;

            if(firsName.Length == 0 || name.Length == 0 || lastName.Length == 0)
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
                this.Close();
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
