/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC24
 * Fecha: 04/11/2026
 * Hora: 10:30 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo2
{
	/// <summary>
	/// Description of Puntos.
	/// </summary>
	public partial class Puntos : Form
	{
		public Puntos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
		double x1, x2, y1, y2, D;
    
    	x1 = Convert.ToDouble(txtX1.Text);
    	x2 = Convert.ToDouble(txtX2.Text);
    	y1 = Convert.ToDouble(txtY1.Text);
    	y2 = Convert.ToDouble(txtY2.Text);
    
    	D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    
    	lblResultado.Text = "La distancia es=" + String.Format("{0:F2}", D);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			txtX1.Text="";
			txtX2.Text="";
			txtY1.Text="";
			txtY2.Text="";				
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			FormularioPrincipal N= new FormularioPrincipal();
			N.Show();
			this.Close();
		}
	}
}
