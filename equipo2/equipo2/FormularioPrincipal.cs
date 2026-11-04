/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC12
 * Fecha: 04/11/2026
 * Hora: 07:47 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo2
{
	/// <summary>
	/// Description of FormularioPrincipal.
	/// </summary>
	public partial class FormularioPrincipal : Form
	{
		public FormularioPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DolaresToolStripMenuItemClick(object sender, EventArgs e)
		{
			dolares d=new dolares();
			d.Show();
			this.Hide();
		}
		
		void CordenadasToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cordenadas c=new Cordenadas();
			c.Show();
			this.Hide();
		}
		
		void PuntosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Puntos p=new Puntos();
			p.Show();
			this.Hide();
		}
	}
}
