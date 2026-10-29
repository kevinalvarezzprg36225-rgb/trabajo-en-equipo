/*
 * Creado por SharpDevelop.
 * Usuario: zavala
 * Fecha: 29/10/2026
 * Hora: 07:26 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace equipo2
{
	partial class MainForm
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
			this.txtusu = new System.Windows.Forms.TextBox();
			this.txtcontra = new System.Windows.Forms.TextBox();
			this.btnaceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(79, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "usuario";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(79, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "contraseña";
			// 
			// txtusu
			// 
			this.txtusu.Location = new System.Drawing.Point(317, 38);
			this.txtusu.Name = "txtusu";
			this.txtusu.Size = new System.Drawing.Size(234, 22);
			this.txtusu.TabIndex = 2;
			// 
			// txtcontra
			// 
			this.txtcontra.Location = new System.Drawing.Point(317, 112);
			this.txtcontra.Name = "txtcontra";
			this.txtcontra.Size = new System.Drawing.Size(234, 22);
			this.txtcontra.TabIndex = 3;
			// 
			// btnaceptar
			// 
			this.btnaceptar.Location = new System.Drawing.Point(219, 238);
			this.btnaceptar.Name = "btnaceptar";
			this.btnaceptar.Size = new System.Drawing.Size(143, 47);
			this.btnaceptar.TabIndex = 4;
			this.btnaceptar.Text = "aceptar";
			this.btnaceptar.UseVisualStyleBackColor = true;
			this.btnaceptar.Click += new System.EventHandler(this.BtnaceptarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(750, 403);
			this.Controls.Add(this.btnaceptar);
			this.Controls.Add(this.txtcontra);
			this.Controls.Add(this.txtusu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "equipo2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnaceptar;
		private System.Windows.Forms.TextBox txtcontra;
		private System.Windows.Forms.TextBox txtusu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
