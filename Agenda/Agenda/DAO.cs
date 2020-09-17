using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Agenda
{
	public class DAO
	{
		private SqlConnection connection;
		private SqlDataAdapter adapt;
		private SqlCommand cmd;

		public DAO()
		{
			string strConn = ConfigurationManager.ConnectionStrings["DaoConnectionString"].ConnectionString;
			connection = new SqlConnection(strConn);
			connection.Open();
		}

		public void Dispose()
		{
			connection.Close();
		}

		public DataTable List()
		{
			DataTable dt = new DataTable();
			cmd = new SqlCommand("SELECT * from Contatos", connection);
			adapt = new SqlDataAdapter(cmd);

			adapt.Fill(dt);
			return dt;
		}

		public DataTable List(string where, string op)
		{
			DataTable dt = new DataTable();

			if (op == "nome")
			{
				cmd = new SqlCommand($"SELECT * from Contatos where nome like \'%{where}%\'", connection);
			}

			if (op == "telefone")
			{
				cmd = new SqlCommand($"SELECT * from Contatos where celular like \'%{where}%\'", connection);
			}

			if (op == "email")
			{

				cmd = new SqlCommand($"SELECT * from Contatos where email like \'%{where}%\'", connection);
			}

			adapt = new SqlDataAdapter(cmd);

			adapt.Fill(dt);
			return dt;
		}

		public void Insert(Contato contato)
		{
			cmd = new SqlCommand("INSERT INTO Contatos(nome,endereco,celular,email) " +
								"VALUES(@nome,@endereco,@celular,@email)",
								connection);
			
			cmd.Parameters.AddWithValue("@nome", contato.Nome);
			cmd.Parameters.AddWithValue("@endereco", contato.Endereço);
			cmd.Parameters.AddWithValue("@celular", contato.Celular);
			cmd.Parameters.AddWithValue("@email", contato.Email);

			cmd.ExecuteNonQuery();
		}

		public void Update(Contato contato)
		{
			cmd = new SqlCommand("UPDATE Contatos " +
								"SET nome=@nome, endereco=@endereco, celular=@celular,email=@email " +
								"WHERE id=@id",
								connection);
			
			cmd.Parameters.AddWithValue("@id", contato.IdContato);
			cmd.Parameters.AddWithValue("@nome", contato.Nome);
			cmd.Parameters.AddWithValue("@endereco", contato.Endereço);
			cmd.Parameters.AddWithValue("@celular", contato.Celular);
			cmd.Parameters.AddWithValue("@email", contato.Email);

			cmd.ExecuteNonQuery();
		}

		public void Delete(int ID)
		{
			cmd = new SqlCommand("DELETE Contatos WHERE id=@id", connection);

			cmd.Parameters.AddWithValue("@id", ID);

			cmd.ExecuteNonQuery();
		}
	}
}
