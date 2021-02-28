using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BancoSangue
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        public static string SetValueForUser = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //verifies if username and password are correct
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rodrigo Santos\Documents\Visual Studio 2019\Projects\BancoSangue\BD_Management.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Table_Func Where Username = '" + txtUser.Text.Trim() + "' and Password = '" + txtPass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                SetValueForUser = txtUser.Text;

                new Consultar_Dadores().Show();
                MessageBox.Show("Sessão Iniciada Como: " + txtUser.Text + "\n" + DateTime.Now.ToString());
                this.Hide();

                //creates a log file with all logins done
                StringBuilder sb = new StringBuilder();
                sb.Append("Logged In: " + txtUser.Text + "\t" + DateTime.Now.ToString() + "\n");
                File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", sb.ToString());
            }
            else
            {
                //in case of incorrect username and/or password displays a Message Box...
                MessageBox.Show("Introduza as informações corretas", "Erro");
                ClearFields(); //...and clear the fields
            }
        }

        private void ClearFields()
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            StringBuilder sb = new StringBuilder();
            sb.Append("Application Exited: " + "\t" + DateTime.Now.ToString() + "\n");
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", sb.ToString());
        }

        private void lbl_Criar_Click(object sender, EventArgs e)
        {
            new Criar().Show();
            this.Hide();
        }
    }
}
