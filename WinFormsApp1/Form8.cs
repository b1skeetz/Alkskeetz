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
    public partial class FormEditingProfile : Form
    {
        public FormEditingProfile()
        {
            InitializeComponent();
        }

        private void buttonEditing_Click(object sender, EventArgs e)
        {
            profile profile = new profile();
            profile.Show();
            this.Close();
        }
    }
}
