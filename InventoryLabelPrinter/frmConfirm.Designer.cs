namespace InventoryLabelPrinter
{
	partial class frmConfirm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirm));
            this.grpImprimir = new System.Windows.Forms.GroupBox();
            this.lblImpresora = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFaltantes = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblLabelFaltantes = new System.Windows.Forms.Label();
            this.lblLabelImpresora = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblLabelCantidad = new System.Windows.Forms.Label();
            this.pbImprimir = new System.Windows.Forms.ProgressBar();
            this.lblPorciento = new System.Windows.Forms.Label();
            this.picLabel = new System.Windows.Forms.PictureBox();
            this.grpImprimir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // grpImprimir
            // 
            this.grpImprimir.Controls.Add(this.lblImpresora);
            this.grpImprimir.Controls.Add(this.btnCancelar);
            this.grpImprimir.Controls.Add(this.lblFaltantes);
            this.grpImprimir.Controls.Add(this.btnImprimir);
            this.grpImprimir.Controls.Add(this.lblLabelFaltantes);
            this.grpImprimir.Controls.Add(this.lblLabelImpresora);
            this.grpImprimir.Controls.Add(this.lblCantidad);
            this.grpImprimir.Controls.Add(this.lblLabelCantidad);
            this.grpImprimir.Location = new System.Drawing.Point(13, 115);
            this.grpImprimir.Name = "grpImprimir";
            this.grpImprimir.Size = new System.Drawing.Size(261, 133);
            this.grpImprimir.TabIndex = 1;
            this.grpImprimir.TabStop = false;
            this.grpImprimir.Text = "Print";
            // 
            // lblImpresora
            // 
            this.lblImpresora.AutoSize = true;
            this.lblImpresora.Location = new System.Drawing.Point(147, 70);
            this.lblImpresora.Name = "lblImpresora";
            this.lblImpresora.Size = new System.Drawing.Size(87, 13);
            this.lblImpresora.TabIndex = 5;
            this.lblImpresora.Text = "ZEBRA ZD500R";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(134, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Close";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFaltantes
            // 
            this.lblFaltantes.AutoSize = true;
            this.lblFaltantes.Location = new System.Drawing.Point(147, 47);
            this.lblFaltantes.Name = "lblFaltantes";
            this.lblFaltantes.Size = new System.Drawing.Size(13, 13);
            this.lblFaltantes.TabIndex = 4;
            this.lblFaltantes.Text = "0";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(24, 97);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(104, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Print";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_ClickAsync);
            // 
            // lblLabelFaltantes
            // 
            this.lblLabelFaltantes.AutoSize = true;
            this.lblLabelFaltantes.Location = new System.Drawing.Point(15, 47);
            this.lblLabelFaltantes.Name = "lblLabelFaltantes";
            this.lblLabelFaltantes.Size = new System.Drawing.Size(84, 13);
            this.lblLabelFaltantes.TabIndex = 3;
            this.lblLabelFaltantes.Text = "Pending to print:";
            // 
            // lblLabelImpresora
            // 
            this.lblLabelImpresora.AutoSize = true;
            this.lblLabelImpresora.Location = new System.Drawing.Point(15, 70);
            this.lblLabelImpresora.Name = "lblLabelImpresora";
            this.lblLabelImpresora.Size = new System.Drawing.Size(40, 13);
            this.lblLabelImpresora.TabIndex = 2;
            this.lblLabelImpresora.Text = "Printer:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(147, 25);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(13, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "0";
            // 
            // lblLabelCantidad
            // 
            this.lblLabelCantidad.AutoSize = true;
            this.lblLabelCantidad.Location = new System.Drawing.Point(15, 25);
            this.lblLabelCantidad.Name = "lblLabelCantidad";
            this.lblLabelCantidad.Size = new System.Drawing.Size(89, 13);
            this.lblLabelCantidad.TabIndex = 0;
            this.lblLabelCantidad.Text = "Number of labels:";
            // 
            // pbImprimir
            // 
            this.pbImprimir.Location = new System.Drawing.Point(51, 254);
            this.pbImprimir.Name = "pbImprimir";
            this.pbImprimir.Size = new System.Drawing.Size(223, 18);
            this.pbImprimir.TabIndex = 4;
            // 
            // lblPorciento
            // 
            this.lblPorciento.AutoSize = true;
            this.lblPorciento.Location = new System.Drawing.Point(14, 256);
            this.lblPorciento.Name = "lblPorciento";
            this.lblPorciento.Size = new System.Drawing.Size(21, 13);
            this.lblPorciento.TabIndex = 5;
            this.lblPorciento.Text = "0%";
            // 
            // picLabel
            // 
            this.picLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLabel.Image = ((System.Drawing.Image)(resources.GetObject("picLabel.Image")));
            this.picLabel.Location = new System.Drawing.Point(13, 12);
            this.picLabel.Name = "picLabel";
            this.picLabel.Size = new System.Drawing.Size(261, 96);
            this.picLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLabel.TabIndex = 0;
            this.picLabel.TabStop = false;
            // 
            // frmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 279);
            this.Controls.Add(this.lblPorciento);
            this.Controls.Add(this.pbImprimir);
            this.Controls.Add(this.grpImprimir);
            this.Controls.Add(this.picLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.frmConfirm_Load);
            this.grpImprimir.ResumeLayout(false);
            this.grpImprimir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picLabel;
		private System.Windows.Forms.GroupBox grpImprimir;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Label lblLabelCantidad;
		private System.Windows.Forms.Label lblImpresora;
		private System.Windows.Forms.Label lblFaltantes;
		private System.Windows.Forms.Label lblLabelFaltantes;
		private System.Windows.Forms.Label lblLabelImpresora;
		private System.Windows.Forms.ProgressBar pbImprimir;
		private System.Windows.Forms.Label lblPorciento;
	}
}