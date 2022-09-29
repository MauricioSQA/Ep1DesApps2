namespace TestWindows_WCF_Ventas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRs = new System.Windows.Forms.Label();
            this.lblRUC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUbigeo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.dtgFacturas = new System.Windows.Forms.DataGridView();
            this.Num_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_can = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellNom_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(106, 27);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(87, 23);
            this.txtCod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "F.Inicio:";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(304, 27);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(86, 23);
            this.dtpFecIni.TabIndex = 3;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(525, 27);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(86, 23);
            this.dtpFecFin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "F.Fin:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(649, 24);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Razon social:";
            // 
            // lblRs
            // 
            this.lblRs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRs.Location = new System.Drawing.Point(106, 67);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(284, 31);
            this.lblRs.TabIndex = 8;
            // 
            // lblRUC
            // 
            this.lblRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRUC.Location = new System.Drawing.Point(482, 68);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(150, 30);
            this.lblRUC.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "RUC:";
            // 
            // lblUbigeo
            // 
            this.lblUbigeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUbigeo.Location = new System.Drawing.Point(482, 112);
            this.lblUbigeo.Name = "lblUbigeo";
            this.lblUbigeo.Size = new System.Drawing.Size(150, 31);
            this.lblUbigeo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ubicación:";
            // 
            // lblDir
            // 
            this.lblDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDir.Location = new System.Drawing.Point(106, 112);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(284, 31);
            this.lblDir.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Dirección:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Deuda";
            // 
            // lblDeuda
            // 
            this.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuda.Location = new System.Drawing.Point(106, 158);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(150, 31);
            this.lblDeuda.TabIndex = 16;
            this.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtgFacturas
            // 
            this.dtgFacturas.AllowUserToAddRows = false;
            this.dtgFacturas.AllowUserToDeleteRows = false;
            this.dtgFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_fac,
            this.Fec_fac,
            this.Fec_can,
            this.Estado,
            this.Total,
            this.Cod_ven,
            this.ApellNom_ven});
            this.dtgFacturas.Location = new System.Drawing.Point(34, 224);
            this.dtgFacturas.Name = "dtgFacturas";
            this.dtgFacturas.ReadOnly = true;
            this.dtgFacturas.RowHeadersVisible = false;
            this.dtgFacturas.RowTemplate.Height = 25;
            this.dtgFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFacturas.Size = new System.Drawing.Size(732, 194);
            this.dtgFacturas.TabIndex = 17;
            // 
            // Num_fac
            // 
            this.Num_fac.DataPropertyName = "Num_fac";
            this.Num_fac.HeaderText = "Nro. Factura";
            this.Num_fac.Name = "Num_fac";
            this.Num_fac.ReadOnly = true;
            // 
            // Fec_fac
            // 
            this.Fec_fac.DataPropertyName = "Fec_fac";
            this.Fec_fac.HeaderText = "Fecha facturacion";
            this.Fec_fac.Name = "Fec_fac";
            this.Fec_fac.ReadOnly = true;
            // 
            // Fec_can
            // 
            this.Fec_can.DataPropertyName = "Fec_can";
            this.Fec_can.HeaderText = "Fecha cancelacion";
            this.Fec_can.Name = "Fec_can";
            this.Fec_can.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total(S/.)";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Cod_ven
            // 
            this.Cod_ven.DataPropertyName = "Cod_ven";
            this.Cod_ven.HeaderText = "Cod. vendedor";
            this.Cod_ven.Name = "Cod_ven";
            this.Cod_ven.ReadOnly = true;
            // 
            // ApellNom_ven
            // 
            this.ApellNom_ven.DataPropertyName = "ApellNom_ven";
            this.ApellNom_ven.HeaderText = "Apellidos y nombres vendedor";
            this.ApellNom_ven.Name = "ApellNom_ven";
            this.ApellNom_ven.ReadOnly = true;
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(616, 452);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(150, 31);
            this.lblRegistros.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(544, 453);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Registros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtgFacturas);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblUbigeo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRUC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Servicios Cliente Factura ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCod;
        private Label label2;
        private DateTimePicker dtpFecIni;
        private DateTimePicker dtpFecFin;
        private Label label3;
        private Button btnConsultar;
        private Label label4;
        private Label lblRs;
        private Label lblRUC;
        private Label label7;
        private Label lblUbigeo;
        private Label label9;
        private Label lblDir;
        private Label label11;
        private Label label12;
        private Label lblDeuda;
        private DataGridView dtgFacturas;
        private Label lblRegistros;
        private Label label15;
        private DataGridViewTextBoxColumn Num_fac;
        private DataGridViewTextBoxColumn Fec_fac;
        private DataGridViewTextBoxColumn Fec_can;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Cod_ven;
        private DataGridViewTextBoxColumn ApellNom_ven;
    }
}