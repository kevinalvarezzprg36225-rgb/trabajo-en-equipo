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
			this.txtcontra2 = new System.Windows.Forms.TextBox();
			this.txtusu2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnverificar
			// 
			this.btnverificar.Location = new System.Drawing.Point(207, 260);
			this.btnverificar.Name = "btnverificar";
			this.btnverificar.Size = new System.Drawing.Size(143, 47);
			this.btnverificar.TabIndex = 9;
			this.btnverificar.Text = "iniciar secion";
			this.btnverificar.UseVisualStyleBackColor = true;
			// 
			// txtcontra2
			// 
			this.txtcontra2.Location = new System.Drawing.Point(305, 134);
			this.txtcontra2.Name = "txtcontra2";
			this.txtcontra2.Size = new System.Drawing.Size(234, 22);
			this.txtcontra2.TabIndex = 8;
			// 
			// txtusu2
			// 
			this.txtusu2.Location = new System.Drawing.Point(305, 60);
			this.txtusu2.Name = "txtusu2";
			this.txtusu2.Size = new System.Drawing.Size(234, 22);
			this.txtusu2.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(67, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "contraseña";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(67, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "usuario";
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 366);
			this.Controls.Add(this.btnverificar);
			this.Controls.Add(this.txtcontra2);
			this.Controls.Add(this.txtusu2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "login";
			this.Text = "login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtusu2;
		private System.Windows.Forms.TextBox txtcontra2;
		private System.Windows.Forms.Button btnverificar;
	}
}
