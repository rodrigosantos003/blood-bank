using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BancoSangue
{
    public partial class N_Colheitas : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rodrigo Santos\Documents\Visual Studio 2019\Projects\BancoSangue\BD_Management.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public N_Colheitas()
        {
            InitializeComponent();
        }

        private void DBC()
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select [Tipo de Sangue], [Fator RH] from Table_Dados", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgv_Colheitas.DataSource = dt;
            con.Close();
        }

        private void Showlbl()
        {
            lblTipo.Visible = true;
            lblNumero.Visible = true;
        }

        //displays data on DataGridView
        private void N_Colheitas_Load(object sender, EventArgs e)
        {
            DBC();

            lblTipo.Visible = false;
            lblNumero.Visible = false;
        }

        //when teh button is clicked, shows the total of harvests
        private void btnTotal_Click(object sender, EventArgs e)
        {
            DBC();

            int x = dgv_Colheitas.RowCount - 1;

            Showlbl();
            lblTipo.Text = "Total:";
            lblNumero.Text = x.ToString();
        }

        //when teh button is clicked, shows teh total of type A
        private void btnTotal_A_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from Table_Dados where [Tipo de Sangue] = 'A'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgv_Colheitas.DataSource = dt;
            int x = dgv_Colheitas.RowCount - 1;

            Showlbl();
            lblTipo.Text = "Total Tipo A:";
            lblNumero.Text = x.ToString();

            con.Close();
        }

        //when teh button is clicked, shows teh total of type B
        private void btnTotal_B_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from Table_Dados where [Tipo de Sangue] = 'B'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgv_Colheitas.DataSource = dt;
            int x = dgv_Colheitas.RowCount - 1;

            Showlbl();
            lblTipo.Text = "Total Tipo B:";
            lblNumero.Text = x.ToString();

            con.Close();
        }

        //when teh button is clicked, shows teh total of type AB
        private void btnTotal_AB_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from Table_Dados where [Tipo de Sangue] = 'AB'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgv_Colheitas.DataSource = dt;
            int x = dgv_Colheitas.RowCount - 1;

            Showlbl();
            lblTipo.Text = "Total Tipo AB:";
            lblNumero.Text = x.ToString();

            con.Close();
        }

        //when teh button is clicked, shows teh total of type O
        private void btnTotal_O_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from Table_Dados where [Tipo de Sangue] = 'O'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgv_Colheitas.DataSource = dt;
            int x = dgv_Colheitas.RowCount - 1;

            Showlbl();
            lblTipo.Text = "Total Tipo O:";
            lblNumero.Text = x.ToString();

            con.Close();
        }

        private void voltarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Consultar_Dadores().Show();
            this.Hide();
        }

        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();

            StringBuilder sb = new StringBuilder();
            sb.Append("Logged Out: " + Login.SetValueForUser + "\t" + DateTime.Now.ToString() + "\n");
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", sb.ToString());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

            StringBuilder sb = new StringBuilder();
            sb.Append("Application Exited: " + "\t" + DateTime.Now.ToString() + "\n");
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "logs.txt", sb.ToString());
        }
    }
}
