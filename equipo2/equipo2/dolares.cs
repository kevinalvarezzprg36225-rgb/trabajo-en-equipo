/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC12
 * Fecha: 04/11/2026
 * Hora: 08:18 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo2
{
	/// <summary>
	/// Description of dolares.
	/// </summary>
	public partial class dolares : Form
	{
		public dolares()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnDMXClick(object sender, EventArgs e)
		{
			double cantidad=0, Resultado=0;
			cantidad = Convert.ToDouble(txtcantidad.Text);
			Resultado = cantidad * 18.86;
			lblMx.Text="Resultado = "+ Convert.ToString(Resultado) +"MX";
		}
		
		void BtnMxDClick(object sender, EventArgs e)
		{
			double cantidad=0, Resultado=0;
			cantidad = Convert.ToDouble(txtcantidad.Text);
			Resultado = cantidad * 0.054;
			lblDl.Text="Resultado = "+ Convert.ToString(Resultado) +"Dolares";
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			FormularioPrincipal N= new FormularioPrincipal();
			N.Show();
			this.Close();
		}
	}
}
