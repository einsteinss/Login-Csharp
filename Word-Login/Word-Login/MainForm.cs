/*
 * Created by SharpDevelop.
 * User: Sela Smith
 * Date: 09/02/2021
 * Time: 10:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Word_Login
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			Usuario.Focus();
		}
		void FecharClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void CodigoTextChanged(object sender, EventArgs e)
		{
			Codigo.PasswordChar = '*';
		}
		void UsuarioTextChanged(object sender, EventArgs e)
		{
	
		}
		void LimparClick(object sender, EventArgs e)
		{
			Usuario.Clear();
			Codigo.Clear();
			Usuario.Focus();
		}
		void EntrarClick(object sender, EventArgs e)
		{
			if (Usuario.Text == "SS" && Codigo.Text == "1234")
			{
				new F2().Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Os Dados que introduziu estão incorretos.!");
				Usuario.Clear();
				Codigo.Clear();
				Usuario.Focus();
			}
		}
		void ErroClick(object sender, EventArgs e)
		{
			MessageBox.Show("Apoio ao Cliente: +244 947-363-496 ");
		}
		void FecharMouseHover(object sender, EventArgs e)
		{
			this.Fechar.BackColor = System.Drawing.Color.Black;
			this.Fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		}
		void FecharMouseLeave(object sender, EventArgs e)
		{
			this.Fechar.BackColor = System.Drawing.Color.White;
			this.Fechar.ForeColor = System.Drawing.SystemColors.ControlText;
		}
		
	}
}
