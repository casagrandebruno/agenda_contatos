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

namespace Agenda
{
	public partial class Form1 : Form
	{
		SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Agenda;Integrated Security=True");
		SqlCommand cmd;
		SqlDataAdapter adapt;
		int ID = 0;

		public Form1()
		{
			InitializeComponent();
			ExibirDados();
		}

		private void ExibirDados()
		{
			try
			{
				con.Open();
				DataTable dt = new DataTable();
				adapt = new SqlDataAdapter("SELECT * FROM Contatos", con);
				adapt.Fill(dt);
				dgvAgenda.DataSource = dt;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				con.Close();
			}
		}

		private void LimparDados()
		{
			txtNome.Text = "";
			txtEndereco.Text = "";
			txtCelular.Text = "";
			txtTelefone.Text = "";
			txtEmail.Text = "";
			ID = 0;
		}

		
		private void btnNovo_Click(object sender, EventArgs e)
		{
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
		}

		private void btnAtualizar_Click(object sender, EventArgs e)
		{
		}

		private void btnDeletar_Click(object sender, EventArgs e)
		{
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
		}

		private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
