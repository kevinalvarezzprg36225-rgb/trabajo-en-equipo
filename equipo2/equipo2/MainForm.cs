/*
 * Creado por SharpDevelop.
 * Usuario: zavala
 * Fecha: 29/10/2026
 * Hora: 07:26 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace equipo2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string usuario;
		public int contraseña;
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
		
		void BtnaceptarClick(object sender, EventArgs e)
		{
			usuario = txtusu.Text;
			contraseña = Convert.ToInt16(txtcontra.Text);
			login l = new login();
			l.Show();
			this.Hide();
		}
	}
}
