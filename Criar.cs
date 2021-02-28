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

namespace BancoSangue
{
    public partial class Criar : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rodrigo Santos\Documents\Visual Studio 2019\Projects\BancoSangue\BD_Management.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        SqlCommand cmd;

        public Criar()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            cmd = new SqlCommand("INSERT INTO [Table_Func] ([Nome], [Username], [Password]) VALUES (@Nome, @Username, @Password)", con);

            con.Open();
            cmd.Parameters.AddWithValue("@Nome", txt_Name.Text);
            cmd.Parameters.AddWithValue("@Username", txt_User.Text);
            cmd.Parameters.AddWithValue("@Password", txt_Password.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Conta Criada com Sucesso");

            new Login().Show();
            this.Close();
        }
    }
}
