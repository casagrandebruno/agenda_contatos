namespace Agenda
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label1 = new System.Windows.Forms.Label();
			this.txtBusca = new System.Windows.Forms.TextBox();
			this.btnBuscaEmail = new System.Windows.Forms.Button();
			this.btnBuscaTelefone = new System.Windows.Forms.Button();
			this.btnBuscaNome = new System.Windows.Forms.Button();
			this.lvAgenda = new System.Windows.Forms.ListView();
			this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnEndereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnEdit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(176, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Busca de Contatos";
			// 
			// txtBusca
			// 
			this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtBusca.Location = new System.Drawing.Point(12, 68);
			this.txtBusca.Name = "txtBusca";
			this.txtBusca.Size = new System.Drawing.Size(559, 20);
			this.txtBusca.TabIndex = 21;
			// 
			// btnBuscaEmail
			// 
			this.btnBuscaEmail.Location = new System.Drawing.Point(464, 94);
			this.btnBuscaEmail.Name = "btnBuscaEmail";
			this.btnBuscaEmail.Size = new System.Drawing.Size(107, 23);
			this.btnBuscaEmail.TabIndex = 22;
			this.btnBuscaEmail.Text = "Buscar &Email";
			this.btnBuscaEmail.UseVisualStyleBackColor = true;
			// 
			// btnBuscaTelefone
			// 
			this.btnBuscaTelefone.Location = new System.Drawing.Point(351, 94);
			this.btnBuscaTelefone.Name = "btnBuscaTelefone";
			this.btnBuscaTelefone.Size = new System.Drawing.Size(107, 23);
			this.btnBuscaTelefone.TabIndex = 22;
			this.btnBuscaTelefone.Text = "Buscar &Telefone";
			this.btnBuscaTelefone.UseVisualStyleBackColor = true;
			// 
			// btnBuscaNome
			// 
			this.btnBuscaNome.Location = new System.Drawing.Point(238, 94);
			this.btnBuscaNome.Name = "btnBuscaNome";
			this.btnBuscaNome.Size = new System.Drawing.Size(107, 23);
			this.btnBuscaNome.TabIndex = 22;
			this.btnBuscaNome.Text = "Buscar &Nome";
			this.btnBuscaNome.UseVisualStyleBackColor = true;
			// 
			// lvAgenda
			// 
			this.lvAgenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnNome,
            this.columnEndereco,
            this.columnTelefone,
            this.columnEmail});
			this.lvAgenda.HideSelection = false;
			this.lvAgenda.Location = new System.Drawing.Point(12, 156);
			this.lvAgenda.Name = "lvAgenda";
			this.lvAgenda.Size = new System.Drawing.Size(559, 196);
			this.lvAgenda.TabIndex = 23;
			this.lvAgenda.UseCompatibleStateImageBehavior = false;
			this.lvAgenda.View = System.Windows.Forms.View.Details;
			// 
			// columnNome
			// 
			this.columnNome.Text = "Nome";
			// 
			// columnEndereco
			// 
			this.columnEndereco.Text = "Endereço";
			this.columnEndereco.Width = 250;
			// 
			// columnTelefone
			// 
			this.columnTelefone.Text = "Telefone";
			this.columnTelefone.Width = 80;
			// 
			// columnEmail
			// 
			this.columnEmail.Text = "Email";
			this.columnEmail.Width = 130;
			// 
			// columnId
			// 
			this.columnId.Text = "Id";
			this.columnId.Width = 30;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(464, 359);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(90, 23);
			this.btnEdit.TabIndex = 24;
			this.btnEdit.Text = "Editar";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 395);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.lvAgenda);
			this.Controls.Add(this.btnBuscaNome);
			this.Controls.Add(this.btnBuscaTelefone);
			this.Controls.Add(this.btnBuscaEmail);
			this.Controls.Add(this.txtBusca);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.Text = "Agenda";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBusca;
		private System.Windows.Forms.Button btnBuscaEmail;
		private System.Windows.Forms.Button btnBuscaTelefone;
		private System.Windows.Forms.Button btnBuscaNome;
		private System.Windows.Forms.ListView lvAgenda;
		private System.Windows.Forms.ColumnHeader columnId;
		private System.Windows.Forms.ColumnHeader columnNome;
		private System.Windows.Forms.ColumnHeader columnEndereco;
		private System.Windows.Forms.ColumnHeader columnTelefone;
		private System.Windows.Forms.ColumnHeader columnEmail;
		private System.Windows.Forms.Button btnEdit;
	}
}