namespace InventoryLabelPrinter
{
	partial class frmLabels
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
            this.dgActivos = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtCodigoFinal = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgActivos)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgActivos
            // 
            this.dgActivos.AllowDrop = true;
            this.dgActivos.AllowUserToAddRows = false;
            this.dgActivos.AllowUserToDeleteRows = false;
            this.dgActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActivos.Location = new System.Drawing.Point(12, 161);
            this.dgActivos.MultiSelect = false;
            this.dgActivos.Name = "dgActivos";
            this.dgActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgActivos.Size = new System.Drawing.Size(856, 372);
            this.dgActivos.TabIndex = 7;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(13, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(47, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Code";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(13, 64);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(89, 20);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Description";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(13, 96);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Type";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(432, 32);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(54, 20);
            this.lblGrupo.TabIndex = 3;
            this.lblGrupo.Text = "Group";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(432, 66);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(46, 20);
            this.lblSerie.TabIndex = 4;
            this.lblSerie.Text = "Serie";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(118, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(128, 26);
            this.txtCodigo.TabIndex = 0;
            //this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(118, 61);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(308, 26);
            this.txtDesc.TabIndex = 2;
            //this.txtDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesc_KeyDown);
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(492, 61);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(346, 26);
            this.txtSerie.TabIndex = 5;
            // this.txtSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie_KeyDown);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(118, 94);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(308, 28);
            this.cboTipo.TabIndex = 3;
            //this.cboTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTipo_KeyDown);
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(492, 29);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(346, 28);
            this.cboGrupo.TabIndex = 4;
            //this.cboGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboGrupo_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(492, 94);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 33);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Seach";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnLimpiar);
            this.gbBuscar.Controls.Add(this.lblHasta);
            this.gbBuscar.Controls.Add(this.txtCodigoFinal);
            this.gbBuscar.Controls.Add(this.lblSerie);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.lblGrupo);
            this.gbBuscar.Controls.Add(this.cboGrupo);
            this.gbBuscar.Controls.Add(this.lblCodigo);
            this.gbBuscar.Controls.Add(this.cboTipo);
            this.gbBuscar.Controls.Add(this.lblDesc);
            this.gbBuscar.Controls.Add(this.txtSerie);
            this.gbBuscar.Controls.Add(this.lblTipo);
            this.gbBuscar.Controls.Add(this.txtDesc);
            this.gbBuscar.Controls.Add(this.txtCodigo);
            this.gbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscar.Location = new System.Drawing.Point(12, 13);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(857, 142);
            this.gbBuscar.TabIndex = 2;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Fixed Asset Search";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(648, 94);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 33);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Clear";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(246, 32);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(27, 20);
            this.lblHasta.TabIndex = 7;
            this.lblHasta.Text = "To";
            // 
            // txtCodigoFinal
            // 
            this.txtCodigoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFinal.Location = new System.Drawing.Point(299, 29);
            this.txtCodigoFinal.Name = "txtCodigoFinal";
            this.txtCodigoFinal.Size = new System.Drawing.Size(127, 26);
            this.txtCodigoFinal.TabIndex = 1;
            //this.txtCodigoFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoFinal_KeyDown);
            this.txtCodigoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoFinal_KeyPress);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(769, 539);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(99, 30);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Print (USB)";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_ClickAsync);
            // 
            // frmLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 580);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.dgActivos);
            this.Name = "frmLabels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label Printing - Zebra ZD500R (GDI)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEtiquetas_FormClosed);
            this.Load += new System.EventHandler(this.frmEtiquetas_Load);
            this.SizeChanged += new System.EventHandler(this.frmEtiquetas_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgActivos)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgActivos;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.ComboBox cboGrupo;
		private System.Windows.Forms.ComboBox cboTipo;
		private System.Windows.Forms.TextBox txtSerie;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblSerie;
		private System.Windows.Forms.Label lblGrupo;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.GroupBox gbBuscar;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Label lblHasta;
		private System.Windows.Forms.TextBox txtCodigoFinal;
		private System.Windows.Forms.Button btnLimpiar;
	}
}