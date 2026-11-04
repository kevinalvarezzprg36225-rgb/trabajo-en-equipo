/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC12
 * Fecha: 04/11/2026
 * Hora: 08:30 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace equipo2
{
	partial class Cordenadas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cordenadas));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtX = new System.Windows.Forms.TextBox();
			this.txtY = new System.Windows.Forms.TextBox();
			this.btnCordena = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnregresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "X:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 65);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Y:";
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(58, 24);
			this.txtX.Margin = new System.Windows.Forms.Padding(2);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(83, 20);
			this.txtX.TabIndex = 4;
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(58, 68);
			this.txtY.Margin = new System.Windows.Forms.Padding(2);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(83, 20);
			this.txtY.TabIndex = 5;
			// 
			// btnCordena
			// 
			this.btnCordena.Location = new System.Drawing.Point(58, 108);
			this.btnCordena.Margin = new System.Windows.Forms.Padding(2);
			this.btnCordena.Name = "btnCordena";
			this.btnCordena.Size = new System.Drawing.Size(218, 38);
			this.btnCordena.TabIndex = 6;
			this.btnCordena.Text = "Cordenadas:";
			this.btnCordena.UseVisualStyleBackColor = true;
			this.btnCordena.Click += new System.EventHandler(this.BtnCordenaClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(167, 21);
			this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(131, 81);
			this.lblResultado.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(145, 21);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 81);
			this.label3.TabIndex = 8;
			this.label3.Text = "|";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(145, 65);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 41);
			this.label4.TabIndex = 9;
			this.label4.Text = "|";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(58, 162);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(190, 152);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(72, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "IV";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(208, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "II";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(208, 274);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "V";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(72, 274);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "III";
			// 
			// btnregresar
			// 
			this.btnregresar.Location = new System.Drawing.Point(68, 319);
			this.btnregresar.Margin = new System.Windows.Forms.Padding(2);
			this.btnregresar.Name = "btnregresar";
			this.btnregresar.Size = new System.Drawing.Size(163, 25);
			this.btnregresar.TabIndex = 15;
			this.btnregresar.Text = "Regresar";
			this.btnregresar.UseVisualStyleBackColor = true;
			this.btnregresar.Click += new System.EventHandler(this.BtnregresarClick);
			// 
			// Cordenadas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 353);
			this.Controls.Add(this.btnregresar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCordena);
			this.Controls.Add(this.txtY);
			this.Controls.Add(this.txtX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Cordenadas";
			this.Text = "Cordenadas";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnregresar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnCordena;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
