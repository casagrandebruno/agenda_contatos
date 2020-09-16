namespace Agenda
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.dgvAgenda = new System.Windows.Forms.DataGridView();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.btnContato = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(167, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Agenda de Contatos";
			// 
			// dgvAgenda
			// 
			this.dgvAgenda.AllowUserToAddRows = false;
			this.dgvAgenda.AllowUserToDeleteRows = false;
			this.dgvAgenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dgvAgenda.Location = new System.Drawing.Point(20, 330);
			this.dgvAgenda.Name = "dgvAgenda";
			this.dgvAgenda.ReadOnly = true;
			this.dgvAgenda.Size = new System.Drawing.Size(543, 147);
			this.dgvAgenda.TabIndex = 29;
			this.dgvAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellContentClick);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtEmail.Location = new System.Drawing.Point(131, 217);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(428, 20);
			this.txtEmail.TabIndex = 28;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(19, 220);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 27;
			this.label7.Text = "Email";
			// 
			// txtCelular
			// 
			this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtCelular.Location = new System.Drawing.Point(131, 179);
			this.txtCelular.MaxLength = 11;
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(235, 20);
			this.txtCelular.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(19, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 23;
			this.label5.Text = "Celular";
			// 
			// txtEndereco
			// 
			this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
			this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtEndereco.Location = new System.Drawing.Point(131, 102);
			this.txtEndereco.Multiline = true;
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(428, 61);
			this.txtEndereco.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(18, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 21;
			this.label4.Text = "Endereço";
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtNome.Location = new System.Drawing.Point(131, 62);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(428, 20);
			this.txtNome.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(18, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Nome";
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(254, 288);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 33;
			this.btnLimpar.Text = "&Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnDeletar
			// 
			this.btnDeletar.BackColor = System.Drawing.SystemColors.Control;
			this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnDeletar.Location = new System.Drawing.Point(254, 259);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(75, 23);
			this.btnDeletar.TabIndex = 32;
			this.btnDeletar.Text = "&Deletar";
			this.btnDeletar.UseVisualStyleBackColor = true;
			this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.BackColor = System.Drawing.SystemColors.Control;
			this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAtualizar.Location = new System.Drawing.Point(173, 288);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
			this.btnAtualizar.TabIndex = 31;
			this.btnAtualizar.Text = "&Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSalvar.Location = new System.Drawing.Point(172, 259);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 30;
			this.btnSalvar.Text = "&Inserir";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.SystemColors.Control;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnSair.Location = new System.Drawing.Point(335, 259);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 52);
			this.btnSair.TabIndex = 34;
			this.btnSair.Text = "&Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBox1.Location = new System.Drawing.Point(137, 75);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(428, 13);
			this.textBox1.TabIndex = 20;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBox2.Location = new System.Drawing.Point(137, 117);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(428, 51);
			this.textBox2.TabIndex = 22;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBox3.Location = new System.Drawing.Point(137, 191);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(235, 13);
			this.textBox3.TabIndex = 24;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBox5.Location = new System.Drawing.Point(137, 229);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(428, 13);
			this.textBox5.TabIndex = 28;
			// 
			// btnContato
			// 
			this.btnContato.Location = new System.Drawing.Point(484, 182);
			this.btnContato.Name = "btnContato";
			this.btnContato.Size = new System.Drawing.Size(75, 23);
			this.btnContato.TabIndex = 35;
			this.btnContato.Text = "WhatsApp";
			this.btnContato.UseVisualStyleBackColor = true;
			this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 488);
			this.Controls.Add(this.btnContato);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.dgvAgenda);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtCelular);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox5);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Agenda";
			((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvAgenda;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.Button btnAtualizar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button btnContato;
	}
}

