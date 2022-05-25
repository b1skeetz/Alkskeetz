using Microsoft.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //string connectionString = "Server=A1408\\SQLEXPRESS;Database=Database1;Trusted_Connection=yes;";

            /*SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Server=A1408\\SQLEXPRESS;" +
              "Database=Database1;" +
              "User Id=POLYTECH2\\КадыржановД;" + 
              "Password=\"\";";
            conn.Open();*/

            // Создание подключения
            /*SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.CloseAsync();
            }*/
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
