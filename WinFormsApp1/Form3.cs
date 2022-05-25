using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsApp1.Services;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        string name;
        string surname;
        string lastName;
        int ratio;
        DataBaseServise servise = new DataBaseServise();
        string connectionString = "Data Source =(localdb)\\MSSQLLocalDB; DataBase = master;" +
                " Integrated Security=True;";
        string queryString = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //сделай подтверждение (регистрация прошла успешно) и только потом закрытие приложения через 2 сек (2000мс) 
            surname = textBox_Surname.Text;
            name = textBox_Name.Text;
            lastName = textBox_Lastname.Text;
            ratio = Convert.ToInt32(textBox_Ratio.Text);

            if (surname.Length == 0 || name.Length == 0 || lastName.Length == 0)
            {
                label7.Visible = true;
            }
            else if (ratio < 0 || ratio > 100)
            {
                label6.Visible = true;                
            }
            else
            {
                queryString = "INSERT INTO Table_Realtor (Name, Surname, Lastname, Ratio) VALUES ('" +
                    name + "', '" +
                    surname + "', '" +
                    lastName + "', " +
                    ratio + ");";
                label7.Visible = false;
                label6.Visible = false;
                if (servise.CreateCommand(queryString, connectionString))
                {
                    MessageBox.Show("Регистрация риэлтора " + name + " " + surname + " " + lastName + " прошла успешно");
                }
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
