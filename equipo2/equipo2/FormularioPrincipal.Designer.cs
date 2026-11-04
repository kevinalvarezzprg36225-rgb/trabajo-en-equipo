/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC12
 * Fecha: 04/11/2026
 * Hora: 07:47 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace equipo2
{
	partial class FormularioPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dolaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.puntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cordenadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.programasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(364, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// programasToolStripMenuItem
			// 
			this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.dolaresToolStripMenuItem,
									this.puntosToolStripMenuItem,
									this.cordenadasToolStripMenuItem});
			this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
			this.programasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.programasToolStripMenuItem.Text = "P&rogramas.";
			// 
			// dolaresToolStripMenuItem
			// 
			this.dolaresToolStripMenuItem.Name = "dolaresToolStripMenuItem";
			this.dolaresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.dolaresToolStripMenuItem.Text = "&Dolares.";
			this.dolaresToolStripMenuItem.Click += new System.EventHandler(this.DolaresToolStripMenuItemClick);
			// 
			// puntosToolStripMenuItem
			// 
			this.puntosToolStripMenuItem.Name = "puntosToolStripMenuItem";
			this.puntosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.puntosToolStripMenuItem.Text = "&Puntos.";
			this.puntosToolStripMenuItem.Click += new System.EventHandler(this.PuntosToolStripMenuItemClick);
			// 
			// cordenadasToolStripMenuItem
			// 
			this.cordenadasToolStripMenuItem.Name = "cordenadasToolStripMenuItem";
			this.cordenadasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.cordenadasToolStripMenuItem.Text = "&Cordenadas.";
			this.cordenadasToolStripMenuItem.Click += new System.EventHandler(this.CordenadasToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(58, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(240, 162);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// FormularioPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 204);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormularioPrincipal";
			this.Text = "FormularioPrincipal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem cordenadasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem puntosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dolaresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
