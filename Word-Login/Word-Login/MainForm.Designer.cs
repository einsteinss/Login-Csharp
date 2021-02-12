/*
 * Created by SharpDevelop.
 * User: Sela Smith
 * Date: 09/02/2021
 * Time: 10:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Word_Login
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Entrar;
		private System.Windows.Forms.Label Limpar;
		private System.Windows.Forms.Label Erro;
		private System.Windows.Forms.Label Fechar;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.TextBox Usuario;
		private System.Windows.Forms.TextBox Codigo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Entrar = new System.Windows.Forms.Button();
			this.Limpar = new System.Windows.Forms.Label();
			this.Erro = new System.Windows.Forms.Label();
			this.Fechar = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.Usuario = new System.Windows.Forms.TextBox();
			this.Codigo = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(118, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 102);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.label1.Location = new System.Drawing.Point(66, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Iniciar Sessão";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
			this.label2.Location = new System.Drawing.Point(46, 204);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(206, 2);
			this.label2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
			this.label3.Location = new System.Drawing.Point(46, 288);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 2);
			this.label3.TabIndex = 3;
			// 
			// Entrar
			// 
			this.Entrar.BackColor = System.Drawing.Color.White;
			this.Entrar.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Entrar.Location = new System.Drawing.Point(46, 348);
			this.Entrar.Name = "Entrar";
			this.Entrar.Size = new System.Drawing.Size(206, 33);
			this.Entrar.TabIndex = 4;
			this.Entrar.Text = "Entrar";
			this.Entrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Entrar.UseVisualStyleBackColor = false;
			this.Entrar.Click += new System.EventHandler(this.EntrarClick);
			// 
			// Limpar
			// 
			this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Limpar.Location = new System.Drawing.Point(150, 302);
			this.Limpar.Name = "Limpar";
			this.Limpar.Size = new System.Drawing.Size(108, 19);
			this.Limpar.TabIndex = 5;
			this.Limpar.Text = "Limpar Campos";
			this.Limpar.Click += new System.EventHandler(this.LimparClick);
			// 
			// Erro
			// 
			this.Erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Erro.ForeColor = System.Drawing.Color.Crimson;
			this.Erro.Location = new System.Drawing.Point(46, 390);
			this.Erro.Name = "Erro";
			this.Erro.Size = new System.Drawing.Size(166, 19);
			this.Erro.TabIndex = 6;
			this.Erro.Text = "Esqueceu a sua passe.?";
			this.Erro.Click += new System.EventHandler(this.ErroClick);
			// 
			// Fechar
			// 
			this.Fechar.BackColor = System.Drawing.Color.White;
			this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Fechar.Location = new System.Drawing.Point(112, 444);
			this.Fechar.Name = "Fechar";
			this.Fechar.Size = new System.Drawing.Size(76, 19);
			this.Fechar.TabIndex = 7;
			this.Fechar.Text = "Fechar";
			this.Fechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Fechar.Click += new System.EventHandler(this.FecharClick);
			this.Fechar.MouseLeave += new System.EventHandler(this.FecharMouseLeave);
			this.Fechar.MouseHover += new System.EventHandler(this.FecharMouseHover);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
			this.pictureBox2.Location = new System.Drawing.Point(46, 170);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(36, 33);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
			this.pictureBox3.Location = new System.Drawing.Point(45, 254);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(36, 33);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			// 
			// Usuario
			// 
			this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Usuario.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
			this.Usuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.Usuario.Location = new System.Drawing.Point(82, 176);
			this.Usuario.Multiline = true;
			this.Usuario.Name = "Usuario";
			this.Usuario.Size = new System.Drawing.Size(146, 26);
			this.Usuario.TabIndex = 10;
			this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Usuario.TextChanged += new System.EventHandler(this.UsuarioTextChanged);
			// 
			// Codigo
			// 
			this.Codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Codigo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
			this.Codigo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.Codigo.Location = new System.Drawing.Point(82, 260);
			this.Codigo.Multiline = true;
			this.Codigo.Name = "Codigo";
			this.Codigo.Size = new System.Drawing.Size(146, 26);
			this.Codigo.TabIndex = 11;
			this.Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Codigo.TextChanged += new System.EventHandler(this.CodigoTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(299, 489);
			this.Controls.Add(this.Codigo);
			this.Controls.Add(this.Usuario);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.Fechar);
			this.Controls.Add(this.Erro);
			this.Controls.Add(this.Limpar);
			this.Controls.Add(this.Entrar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Word-Login";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
