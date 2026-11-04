/*
 * Creado por SharpDevelop.
 * Usuario: zavala
 * Fecha: 29/10/2026
 * Hora: 07:37 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo2
{
	/// <summary>
	/// Description of login.
	/// </summary>
	public partial class login : Form
	{
		public login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnverificarClick(object sender, EventArgs e)
		{
			string usuario2="", contraseña2="";
			usuario2 = txtusu2.Text;
			contraseña2 = txtcontra2.Text;
			if(equipo2.MainForm.usuario == usuario2 && equipo2.MainForm.contraseña == contraseña2)
			{
				FormularioPrincipal N= new FormularioPrincipal();
				N.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("El usuario o contraseña estan mal. ERROR 404");
				txtusu2.Text="";
				txtcontra2.Text="";
			}
		}
	}
}
