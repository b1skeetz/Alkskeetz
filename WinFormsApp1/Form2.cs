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
    public partial class Form2 : Form
    {
        string name;
        string surname;
        string lastName;
        string phone;
        string email;
        DataBaseServise servise = new DataBaseServise();
        string connectionString = "Data Source =(localdb)\\MSSQLLocalDB; DataBase = master;" +
                " Integrated Security=True;";
        string queryString = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox_Name.Text;
            surname = textBox_Surname.Text;
            lastName = textBox_Lastname.Text;
            phone = textBox_Phone.Text;
            email = textBox_Number.Text;
            
            if(phone.Length == 0 && email.Length == 0)
            {
                label7.Visible = true;
            }
            else
            {
                queryString = "INSERT INTO Table_Clients (Name, Surname, Lastname, PhoneNumber, Email) VALUES ('" +
                   name + "', '" +
                   surname + "', '" +
                   lastName + "', '" +
                   phone + "', '" +
                   email + "');";
                //сделай подтверждение (регистрация прошла успешно) и только потом закрытие приложения через 2 сек (2000мс) 
                label7.Visible = false;
                if (servise.CreateCommand(queryString, connectionString))
                {
                    MessageBox.Show("Регистрация клиента " + name + " " + surname + " " + lastName + " прошла успешно");
                }
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
