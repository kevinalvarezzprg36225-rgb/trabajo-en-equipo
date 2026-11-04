/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC12
 * Fecha: 04/11/2026
 * Hora: 08:30 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo2
{
	/// <summary>
	/// Description of Cordenadas.
	/// </summary>
	public partial class Cordenadas : Form
	{
		public Cordenadas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCordenaClick(object sender, EventArgs e)
		{
			double x=0, y=0;
			x= Convert.ToDouble(txtX.Text);
			y= Convert.ToDouble(txtY.Text);
			if(x < 0 && y >= 0)
				lblResultado.Text="IV";
			else if(x < 0 && y < 0)
				lblResultado.Text="III";
			else if(x > 0 && y >= 0)
				lblResultado.Text="II";
			else if(x > 0 && y < 0)
				lblResultado.Text="V";
			else
				MessageBox.Show("ERROR 404");
		}
		
		void BtnregresarClick(object sender, EventArgs e)
		{
			FormularioPrincipal N= new FormularioPrincipal();
			N.Show();
			this.Close();
		}
	}
}
