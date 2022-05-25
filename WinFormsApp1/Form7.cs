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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void buttonEditing_Click(object sender, EventArgs e)
        {
            FormEditingProfile frm = new FormEditingProfile();
            this.Hide();
            frm.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы точно хотите удалить профиль?");
        }
    }
}
