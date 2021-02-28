using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BancoSangue
{
    public partial class Consultar_Dadores : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rodrigo Santos\Documents\Visual Studio 2019\Projects\BancoSangue\BD_Management.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;

        public Consultar_Dadores()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //displays Table_Dados data on DataGridView
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Table_Dados", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgv_Dadores.DataSource = dt;
            con.Close();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Table_Dados where Nome like '" + txtSearchName.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgv_Dadores.DataSource = dt;
            con.Close();
        }

        private void txtSearchBlood_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Table_Dados where [Tipo de Sangue] like '" + txtSearchBlood.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgv_Dadores.DataSource = dt;
            con.Close();
        }

        private void txtSearchRH_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Table_Dados where [Fator RH] like '" + txtSearchRH.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dgv_Dadores.DataSource = dt;
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtInsertName.Text != "" &&
                txtInsertCC.Text != "" &&
                txtInsertAddress.Text != "" &&
                txtInsertTlm.Text != "" &&
                txtInsertBlood.Text != "" &&
                txtInsertRH.Text != "")
            {
                cmd = new SqlCommand("insert into Table_Dados(Nome, CC, Morada, Telemóvel, [Tipo de Sangue], [Fator RH]) values (@nome, @cc, @morada, @telemóvel, @tipodesangue, @fatorrh)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@nome", txtInsertName.Text);
                cmd.Parameters.AddWithValue("@cc", txtInsertCC.Text);
                cmd.Parameters.AddWithValue("@morada", txtInsertAddress.Text);
                cmd.Parameters.AddWithValue("@telemóvel", txtInsertTlm.Text);
                cmd.Parameters.AddWithValue("@tipodesangue", txtInsertBlood.Text);
                cmd.Parameters.AddWithValue("@fatorrh", txtInsertRH.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Dados Introduzidos com Sucesso!");

                DisplayData();
                ClearData();

            }
            else
                MessageBox.Show("Introduza as Informações!");
        }

        //refresh DataGridView when data is entered
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Table_Dados", con);
            adapt.Fill(dt);
            dgv_Dadores.DataSource = dt;
            con.Close();
        }

        //clear fields for future inserts
        private void ClearData()
        {
            txtInsertName.Text = "";
            txtInsertCC.Text = "";
            txtInsertAddress.Text = "";
            txtInsertTlm.Text = "";
            txtInsertBlood.Text = "";
            txtInsertRH.Text = "";
        }

        private void tsmi_ConsultarColheitas_Click(object sender, EventArgs e)
        {
            new N_Colheitas().Show();
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
