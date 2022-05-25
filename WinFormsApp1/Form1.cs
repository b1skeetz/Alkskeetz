using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            if(radioButton2.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
