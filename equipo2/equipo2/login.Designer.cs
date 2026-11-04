/*
 * Creado por SharpDevelop.
 * Usuario: zavala
 * Fecha: 29/10/2026
 * Hora: 07:37 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace equipo2
{
	partial class login
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
			this.btnverificar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtusu2 = new System.Windows.Forms.TextBox();
			this.txtcontra2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnverificar
			// 
			this.btnverificar.Location = new System.Drawing.Point(90, 115);
			this.btnverificar.Margin = new System.Windows.Forms.Padding(2);
			this.btnverificar.Name = "btnverificar";
			this.btnverificar.Size = new System.Drawing.Size(176, 38);
			this.btnverificar.TabIndex = 9;
			this.btnverificar.Text = "INICIAR SECION.";
			this.btnverificar.UseVisualStyleBackColor = true;
			this.btnverificar.Click += new System.EventHandler(this.BtnverificarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 19);
			this.label1.TabIndex = 10;
			this.label1.Text = "Usuario:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 65);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 19);
			this.label2.TabIndex = 11;
			this.label2.Text = "Contraseña:";
			// 
			// txtusu2
			// 
			this.txtusu2.Location = new System.Drawing.Point(90, 26);
			this.txtusu2.Margin = new System.Windows.Forms.Padding(2);
			this.txtusu2.Name = "txtusu2";
			this.txtusu2.Size = new System.Drawing.Size(255, 20);
			this.txtusu2.TabIndex = 12;
			// 
			// txtcontra2
			// 
			this.txtcontra2.Location = new System.Drawing.Point(90, 68);
			this.txtcontra2.Margin = new System.Windows.Forms.Padding(2);
			this.txtcontra2.Name = "txtcontra2";
			this.txtcontra2.Size = new System.Drawing.Size(176, 20);
			this.txtcontra2.TabIndex = 13;
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 177);
			this.Controls.Add(this.txtcontra2);
			this.Controls.Add(this.txtusu2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnverificar);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "login";
			this.Text = "login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtcontra2;
		private System.Windows.Forms.TextBox txtusu2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnverificar;
	}
}
