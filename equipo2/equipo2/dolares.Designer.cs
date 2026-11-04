/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC12
 * Fecha: 04/11/2026
 * Hora: 08:18 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace equipo2
{
	partial class dolares
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
			this.txtcantidad = new System.Windows.Forms.TextBox();
			this.btnDMX = new System.Windows.Forms.Button();
			this.btnMxD = new System.Windows.Forms.Button();
			this.lblMx = new System.Windows.Forms.Label();
			this.lblDl = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cantidad:";
			// 
			// txtcantidad
			// 
			this.txtcantidad.Location = new System.Drawing.Point(79, 12);
			this.txtcantidad.Margin = new System.Windows.Forms.Padding(2);
			this.txtcantidad.Name = "txtcantidad";
			this.txtcantidad.Size = new System.Drawing.Size(240, 20);
			this.txtcantidad.TabIndex = 3;
			// 
			// btnDMX
			// 
			this.btnDMX.Location = new System.Drawing.Point(11, 51);
			this.btnDMX.Margin = new System.Windows.Forms.Padding(2);
			this.btnDMX.Name = "btnDMX";
			this.btnDMX.Size = new System.Drawing.Size(123, 38);
			this.btnDMX.TabIndex = 5;
			this.btnDMX.Text = "de Dolares a MX:";
			this.btnDMX.UseVisualStyleBackColor = true;
			this.btnDMX.Click += new System.EventHandler(this.BtnDMXClick);
			// 
			// btnMxD
			// 
			this.btnMxD.Location = new System.Drawing.Point(188, 51);
			this.btnMxD.Margin = new System.Windows.Forms.Padding(2);
			this.btnMxD.Name = "btnMxD";
			this.btnMxD.Size = new System.Drawing.Size(131, 38);
			this.btnMxD.TabIndex = 6;
			this.btnMxD.Text = "de MX a Dolares:";
			this.btnMxD.UseVisualStyleBackColor = true;
			this.btnMxD.Click += new System.EventHandler(this.BtnMxDClick);
			// 
			// lblMx
			// 
			this.lblMx.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMx.Location = new System.Drawing.Point(11, 113);
			this.lblMx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMx.Name = "lblMx";
			this.lblMx.Size = new System.Drawing.Size(123, 64);
			this.lblMx.TabIndex = 7;
			// 
			// lblDl
			// 
			this.lblDl.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDl.Location = new System.Drawing.Point(196, 113);
			this.lblDl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDl.Name = "lblDl";
			this.lblDl.Size = new System.Drawing.Size(123, 64);
			this.lblDl.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(11, 138);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(309, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "regresar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dolares
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 186);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblDl);
			this.Controls.Add(this.lblMx);
			this.Controls.Add(this.btnMxD);
			this.Controls.Add(this.btnDMX);
			this.Controls.Add(this.txtcantidad);
			this.Controls.Add(this.label1);
			this.Name = "dolares";
			this.Text = "Dolares🚛";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblDl;
		private System.Windows.Forms.Label lblMx;
		private System.Windows.Forms.Button btnMxD;
		private System.Windows.Forms.Button btnDMX;
		private System.Windows.Forms.TextBox txtcantidad;
		private System.Windows.Forms.Label label1;
	}
}
