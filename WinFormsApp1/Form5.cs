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
    public partial class ClientInput : Form
    {
        string phoneOrEmail;
        string lastName;
        public ClientInput()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            phoneOrEmail = phoneEmailTextBox.Text;
            lastName = textBoxLastName.Text;
            if(phoneOrEmail.Length == 0 || lastName.Length == 0)
            {
                labelWarning.Visible = true;
            }
            else
            {
                labelWarning.Visible = false;
                profile profile = new profile();
                profile.Show();
                this.Close();
            }
        }
    }
}
