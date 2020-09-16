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
using System.Diagnostics;

namespace Agenda
{
	public partial class Form1 : Form
	{
		int ID = 0;

		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

		public Form1()
		{
			InitializeComponent();
			ExibirDados();
		}

		private void ExibirDados()
		{
			DAO dao = new DAO();

			try
			{
				dgvAgenda.DataSource = dao.List();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				dao.Dispose();
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
			txtNome.Text = "";
			txtEndereco.Text = "";
			txtCelular.Text = "";
			txtTelefone.Text = "";
			txtEmail.Text = "";
			txtNome.Focus();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			DAO dao = new DAO();

			if (txtNome.Text != "" && txtEndereco.Text != "" && txtCelular.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "")
			{
				try
				{
					Contato contato = new Contato()
					{
						Nome = txtNome.Text.Trim().ToUpper(),
						Endereço = txtEndereco.Text.Trim().ToUpper(),
						Celular = txtCelular.Text.Trim().ToUpper(),
						Telefone = txtTelefone.Text.Trim().ToUpper(),
						Email = txtEmail.Text.Trim().ToLower()
					};

					dao.Insert(contato);

					MessageBox.Show("Registro incluído com sucesso!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro : " + ex.Message);
				}
				finally
				{
					dao.Dispose();
					ExibirDados();
					LimparDados();
				}
			}
			else
			{
				MessageBox.Show("Informe todos os dados requeridos");
			}
		}

		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			DAO dao = new DAO();

			if (txtNome.Text != "" && txtEndereco.Text != "" && txtCelular.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "")
			{
				try
				{
					Contato contato = new Contato()
					{
						IdContato = ID,
						Nome = txtNome.Text.Trim().ToUpper(),
						Endereço = txtEndereco.Text.Trim().ToUpper(),
						Celular = txtCelular.Text.Trim().ToUpper(),
						Telefone = txtTelefone.Text.Trim().ToUpper(),
						Email = txtEmail.Text.Trim().ToLower()
					};

					dao.Update(contato);
					
					MessageBox.Show("Registro atualizado com sucesso!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro : " + ex.Message);
				}
				finally
				{
					dao.Dispose();
					ExibirDados();
					LimparDados();
				}
			}
			else
			{
				MessageBox.Show("Informe todos os dados requeridos");
			}
		}

		private void btnDeletar_Click(object sender, EventArgs e)
		{
			DAO dao = new DAO();

			if (ID != 0)
			{
				if (MessageBox.Show("Deseja apagar este registro?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						dao.Delete(ID);

						MessageBox.Show("Registro apagado com sucesso!");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Erro : " + ex.Message);
					}
					finally
					{
						dao.Dispose();
						ExibirDados();
						LimparDados();
					}
				}
			}
			else
			{
				MessageBox.Show("Selecione um registro para apagar");
			}
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja sair da Agenda?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
			else
			{
				txtNome.Focus();
			}
		}

		private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				ID = Convert.ToInt32(dgvAgenda.Rows[e.RowIndex].Cells[0].Value.ToString());
				txtNome.Text = dgvAgenda.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtEndereco.Text = dgvAgenda.Rows[e.RowIndex].Cells[2].Value.ToString();
				txtCelular.Text = dgvAgenda.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtTelefone.Text = dgvAgenda.Rows[e.RowIndex].Cells[4].Value.ToString();
				txtEmail.Text = dgvAgenda.Rows[e.RowIndex].Cells[5].Value.ToString();
			}
			catch { }
		}

		private void btnContato_Click(object sender, EventArgs e)
		{
			string strUrl = "https://wa.link/swyq3x";
			Process proc = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo(strUrl);
			proc.StartInfo = startInfo;
			proc.Start();
		}
	}

}
