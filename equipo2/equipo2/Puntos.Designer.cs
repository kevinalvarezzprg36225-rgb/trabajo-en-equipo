/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC24
 * Fecha: 04/11/2026
 * Hora: 10:30 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace equipo2
{
	partial class Puntos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtX1 = new System.Windows.Forms.TextBox();
			this.txtX2 = new System.Windows.Forms.TextBox();
			this.txtY1 = new System.Windows.Forms.TextBox();
			this.txtY2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "X1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "X2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Y1";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Y2";
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(13, 249);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(314, 23);
			this.btnRegresar.TabIndex = 4;
			this.btnRegresar.Text = "regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(13, 142);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 5;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtX1
			// 
			this.txtX1.Location = new System.Drawing.Point(53, 9);
			this.txtX1.Name = "txtX1";
			this.txtX1.Size = new System.Drawing.Size(100, 20);
			this.txtX1.TabIndex = 6;
			// 
			// txtX2
			// 
			this.txtX2.Location = new System.Drawing.Point(53, 40);
			this.txtX2.Name = "txtX2";
			this.txtX2.Size = new System.Drawing.Size(100, 20);
			this.txtX2.TabIndex = 7;
			// 
			// txtY1
			// 
			this.txtY1.Location = new System.Drawing.Point(53, 67);
			this.txtY1.Name = "txtY1";
			this.txtY1.Size = new System.Drawing.Size(100, 20);
			this.txtY1.TabIndex = 8;
			// 
			// txtY2
			// 
			this.txtY2.Location = new System.Drawing.Point(53, 94);
			this.txtY2.Name = "txtY2";
			this.txtY2.Size = new System.Drawing.Size(100, 20);
			this.txtY2.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Limpiar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(116, 142);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(181, 65);
			this.lblResultado.TabIndex = 11;
			// 
			// Puntos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 284);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtY2);
			this.Controls.Add(this.txtY1);
			this.Controls.Add(this.txtX2);
			this.Controls.Add(this.txtX1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Puntos";
			this.Text = "Puntos";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtY2;
		private System.Windows.Forms.TextBox txtY1;
		private System.Windows.Forms.TextBox txtX2;
		private System.Windows.Forms.TextBox txtX1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
