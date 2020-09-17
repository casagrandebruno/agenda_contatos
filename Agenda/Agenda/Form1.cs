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

		public Form1()
		{
			InitializeComponent();
			ExibirDados();
		}

		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
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
			msktxtCelular.Text = "";
			txtEmail.Text = "";
			ID = 0;
		}

		
		private void btnNovo_Click(object sender, EventArgs e)
		{
			txtNome.Text = "";
			txtEndereco.Text = "";
			msktxtCelular.Text = "";
			txtEmail.Text = "";
			txtNome.Focus();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			DAO dao = new DAO();

			if (txtNome.Text != "" && txtEndereco.Text != "" && msktxtCelular.Text != "" && txtEmail.Text != "")
			{
				try
				{
					Contato contato = new Contato()
					{
						Nome = txtNome.Text.Trim().ToUpper(),
						Endereço = txtEndereco.Text.Trim().ToUpper(),
						Celular = msktxtCelular.Text.Trim().ToUpper(),
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

			if (txtNome.Text != "" && txtEndereco.Text != "" && msktxtCelular.Text != "" && txtEmail.Text != "")
			{
				try
				{
					Contato contato = new Contato()
					{
						IdContato = ID,
						Nome = txtNome.Text.Trim().ToUpper(),
						Endereço = txtEndereco.Text.Trim().ToUpper(),
						Celular = msktxtCelular.Text.Trim().ToUpper(),
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

		private void btnContato_Click(object sender, EventArgs e)
		{
			string strUrl;

			string teste = msktxtCelular.Text;

			if (msktxtCelular.Text != "" && msktxtCelular.Text.Trim().Length == 11)
			{
				strUrl = "http://api.whatsapp.com/send?1=pt_BR&phone=55" + msktxtCelular.Text;

				Process proc = new Process();
				ProcessStartInfo startInfo = new ProcessStartInfo(strUrl);
				proc.StartInfo = startInfo;
				proc.Start();
			}
			else
			{
				MessageBox.Show("Formato de telefone não aceito");
			}
		}

		
		private void txtEmail_Leave(object sender, EventArgs e)
		{
			if ((txtNome.Text != "" && txtEndereco.Text != "" && msktxtCelular.Text != "") && !txtEmail.Text.Contains('@') && !(txtEmail.Text.EndsWith(".com") || txtEmail.Text.EndsWith(".com.br")))
			{
				MessageBox.Show("O e-mail inserido é inválido");
				txtEmail.Text = "";
				txtEmail.Focus();
			}
		}


		private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				ID = Convert.ToInt32(dgvAgenda.Rows[e.RowIndex].Cells[0].Value.ToString());
				txtNome.Text = dgvAgenda.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtEndereco.Text = dgvAgenda.Rows[e.RowIndex].Cells[2].Value.ToString();
				msktxtCelular.Text = dgvAgenda.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtEmail.Text = dgvAgenda.Rows[e.RowIndex].Cells[4].Value.ToString();
			}
			catch { }
		}

		private void btnBuscaNome_Click(object sender, EventArgs e)
		{
			DAO dao = new DAO();

			if (txtBusca.Text != "")
			{
				try
				{
					dgvAgenda.DataSource = dao.List(txtBusca.Text.Trim(),"nome");
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

			btnLimparFiltros.Visible = true;
		}

		private void btnBuscaTelefone_Click(object sender, EventArgs e)
		{
			DAO dao = new DAO();

			if (txtBusca.Text != "")
			{
				try
				{
					dgvAgenda.DataSource = dao.List(txtBusca.Text.Trim(), "telefone");
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

			btnLimparFiltros.Visible = true;
		}

		private void btnBuscaEmail_Click(object sender, EventArgs e)
		{
			DAO dao = new DAO();

			if (txtBusca.Text != "")
			{
				try
				{
					dgvAgenda.DataSource = dao.List(txtBusca.Text.Trim(), "email");
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

			btnLimparFiltros.Visible = true;
		}

		private void btnLimparFiltros_Click(object sender, EventArgs e)
		{
			ExibirDados();
			txtBusca.Text = "";
			btnLimparFiltros.Visible = false;
		}
	}

}
