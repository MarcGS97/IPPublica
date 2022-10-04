
namespace IPPublica
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.Actualizar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.BtnCopiarIP01 = new System.Windows.Forms.Button();
			this.BtnCopiarIP02 = new System.Windows.Forms.Button();
			this.BtnCopiarIP03 = new System.Windows.Forms.Button();
			this.TbIP01 = new System.Windows.Forms.TextBox();
			this.TbIP02 = new System.Windows.Forms.TextBox();
			this.TbIP03 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Actualizar
			// 
			this.Actualizar.Location = new System.Drawing.Point(246, 94);
			this.Actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Actualizar.Name = "Actualizar";
			this.Actualizar.Size = new System.Drawing.Size(112, 35);
			this.Actualizar.TabIndex = 0;
			this.Actualizar.Text = "Obtener";
			this.Actualizar.UseVisualStyleBackColor = true;
			this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "https://api.ipify.org/";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 196);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "http://ifconfig.me";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 236);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "http://checkip.dyndns.org/";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(192, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(211, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Obtener Direccion IP Pública";
			// 
			// BtnCopiarIP01
			// 
			this.BtnCopiarIP01.Location = new System.Drawing.Point(470, 146);
			this.BtnCopiarIP01.Name = "BtnCopiarIP01";
			this.BtnCopiarIP01.Size = new System.Drawing.Size(75, 38);
			this.BtnCopiarIP01.TabIndex = 8;
			this.BtnCopiarIP01.Text = "Copiar";
			this.BtnCopiarIP01.UseVisualStyleBackColor = true;
			this.BtnCopiarIP01.Click += new System.EventHandler(this.BtnCopiarIP01_Click);
			// 
			// BtnCopiarIP02
			// 
			this.BtnCopiarIP02.Location = new System.Drawing.Point(470, 187);
			this.BtnCopiarIP02.Name = "BtnCopiarIP02";
			this.BtnCopiarIP02.Size = new System.Drawing.Size(75, 38);
			this.BtnCopiarIP02.TabIndex = 9;
			this.BtnCopiarIP02.Text = "Copiar";
			this.BtnCopiarIP02.UseVisualStyleBackColor = true;
			this.BtnCopiarIP02.Click += new System.EventHandler(this.BtnCopiarIP02_Click);
			// 
			// BtnCopiarIP03
			// 
			this.BtnCopiarIP03.Location = new System.Drawing.Point(470, 227);
			this.BtnCopiarIP03.Name = "BtnCopiarIP03";
			this.BtnCopiarIP03.Size = new System.Drawing.Size(75, 38);
			this.BtnCopiarIP03.TabIndex = 10;
			this.BtnCopiarIP03.Text = "Copiar";
			this.BtnCopiarIP03.UseVisualStyleBackColor = true;
			this.BtnCopiarIP03.Click += new System.EventHandler(this.BtnCopiarIP03_Click);
			// 
			// TbIP01
			// 
			this.TbIP01.Location = new System.Drawing.Point(249, 152);
			this.TbIP01.Name = "TbIP01";
			this.TbIP01.Size = new System.Drawing.Size(187, 26);
			this.TbIP01.TabIndex = 11;
			this.TbIP01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TbIP01.UseWaitCursor = true;
			// 
			// TbIP02
			// 
			this.TbIP02.Location = new System.Drawing.Point(249, 193);
			this.TbIP02.Name = "TbIP02";
			this.TbIP02.Size = new System.Drawing.Size(187, 26);
			this.TbIP02.TabIndex = 12;
			this.TbIP02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TbIP03
			// 
			this.TbIP03.Location = new System.Drawing.Point(249, 233);
			this.TbIP03.Name = "TbIP03";
			this.TbIP03.Size = new System.Drawing.Size(187, 26);
			this.TbIP03.TabIndex = 13;
			this.TbIP03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 368);
			this.Controls.Add(this.TbIP03);
			this.Controls.Add(this.TbIP02);
			this.Controls.Add(this.TbIP01);
			this.Controls.Add(this.BtnCopiarIP03);
			this.Controls.Add(this.BtnCopiarIP02);
			this.Controls.Add(this.BtnCopiarIP01);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Actualizar);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "IP Pública";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Actualizar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button BtnCopiarIP01;
		private System.Windows.Forms.Button BtnCopiarIP02;
		private System.Windows.Forms.Button BtnCopiarIP03;
		private System.Windows.Forms.TextBox TbIP01;
		private System.Windows.Forms.TextBox TbIP02;
		private System.Windows.Forms.TextBox TbIP03;
	}
}

