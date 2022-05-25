using System.Data;
using System.Data.SqlClient;
using WinFormsApp1.Services;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DataBaseServise servise = new DataBaseServise();
        string connectionString = "Data Source =(localdb)\\MSSQLLocalDB; DataBase = master;" +
                " Integrated Security=True;";
        string queryString = "";
        public Form1()
        {
            InitializeComponent();


        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            if (radioButton2.Checked == true)
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

        private void создатьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryString = "CREATE TABLE [dbo].[Table_Clients] ([Id_Client]   BIGINT IDENTITY(1, 1) NOT NULL, " +
                "[Name]NVARCHAR(50) NULL," +
                "[Surname] NVARCHAR(50) NULL," +
                "[Lastname] NVARCHAR(50) NULL," +
                "[PhoneNumber] NVARCHAR(12) NULL," +
                "[Email] TEXT NULL, " +
                "PRIMARY KEY CLUSTERED([Id_Client] ASC), " +
                "UNIQUE NONCLUSTERED([Id_Client] ASC));";
            servise.CreateCommand(queryString, connectionString);

            queryString = "CREATE TABLE [dbo].[Table_Realtor] (" +
                "[Id]    INT IDENTITY(1, 1) NOT NULL," +
                "[Name]  NVARCHAR(50) NOT NULL," +
                "[Surname]  NVARCHAR(50) NOT NULL," +
                "[Lastname] NVARCHAR(50) NOT NULL," +
                "[Ratio]    INT NULL," +
                "PRIMARY KEY CLUSTERED([Id] ASC)," +
                "UNIQUE NONCLUSTERED([Id] ASC));";
            servise.CreateCommand(queryString, connectionString);
        }

        private void удалитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryString = "DROP TABLE IF EXISTS [dbo].[Table_Clients];";
            servise.CreateCommand(queryString, connectionString);
            queryString = "DROP TABLE IF EXISTS [dbo].[Table_Realtor];";
            servise.CreateCommand(queryString, connectionString);


        }
    }

}
