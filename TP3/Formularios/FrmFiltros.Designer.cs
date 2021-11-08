
namespace Formularios
{
    partial class FrmFiltros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltros));
            this.btnOrigen = new System.Windows.Forms.Button();
            this.dgvMostrarConFruto = new System.Windows.Forms.DataGridView();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.dgvSinFruto = new System.Windows.Forms.DataGridView();
            this.dgvMusgos = new System.Windows.Forms.DataGridView();
            this.btnEsporas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFlor = new System.Windows.Forms.ComboBox();
            this.btnFlor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFruto = new System.Windows.Forms.ComboBox();
            this.btnFruto = new System.Windows.Forms.Button();
            this.btnExportarFrutoTxt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAltura = new System.Windows.Forms.ComboBox();
            this.btnExportColorFlor = new System.Windows.Forms.Button();
            this.btnExportOrigen = new System.Windows.Forms.Button();
            this.btnExportAlturaMax = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExportEsporas = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConFruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinFruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusgos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrigen
            // 
            this.btnOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnOrigen.FlatAppearance.BorderSize = 0;
            this.btnOrigen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnOrigen.Location = new System.Drawing.Point(105, 196);
            this.btnOrigen.Name = "btnOrigen";
            this.btnOrigen.Size = new System.Drawing.Size(121, 25);
            this.btnOrigen.TabIndex = 0;
            this.btnOrigen.Text = "Filtrar Origen";
            this.btnOrigen.UseVisualStyleBackColor = false;
            this.btnOrigen.Click += new System.EventHandler(this.btnOrigen_Click);
            // 
            // dgvMostrarConFruto
            // 
            this.dgvMostrarConFruto.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvMostrarConFruto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarConFruto.Location = new System.Drawing.Point(562, 92);
            this.dgvMostrarConFruto.Name = "dgvMostrarConFruto";
            this.dgvMostrarConFruto.RowTemplate.Height = 25;
            this.dgvMostrarConFruto.Size = new System.Drawing.Size(507, 162);
            this.dgvMostrarConFruto.TabIndex = 2;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "Nativa",
            "America",
            "Europa",
            "Asia"});
            this.cmbOrigen.Location = new System.Drawing.Point(105, 167);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 23);
            this.cmbOrigen.TabIndex = 3;
            // 
            // dgvSinFruto
            // 
            this.dgvSinFruto.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvSinFruto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinFruto.Location = new System.Drawing.Point(562, 313);
            this.dgvSinFruto.Name = "dgvSinFruto";
            this.dgvSinFruto.RowTemplate.Height = 25;
            this.dgvSinFruto.Size = new System.Drawing.Size(507, 162);
            this.dgvSinFruto.TabIndex = 4;
            // 
            // dgvMusgos
            // 
            this.dgvMusgos.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvMusgos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusgos.Location = new System.Drawing.Point(562, 525);
            this.dgvMusgos.Name = "dgvMusgos";
            this.dgvMusgos.RowTemplate.Height = 25;
            this.dgvMusgos.Size = new System.Drawing.Size(507, 162);
            this.dgvMusgos.TabIndex = 5;
            // 
            // btnEsporas
            // 
            this.btnEsporas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnEsporas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEsporas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsporas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEsporas.Location = new System.Drawing.Point(221, 490);
            this.btnEsporas.Name = "btnEsporas";
            this.btnEsporas.Size = new System.Drawing.Size(149, 29);
            this.btnEsporas.TabIndex = 7;
            this.btnEsporas.Text = "Max Esporas";
            this.btnEsporas.UseVisualStyleBackColor = false;
            this.btnEsporas.Click += new System.EventHandler(this.btnEsporas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(172)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 38);
            this.panel1.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1046, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 20;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Origen";
            // 
            // cmbFlor
            // 
            this.cmbFlor.AutoCompleteCustomSource.AddRange(new string[] {
            "Roja",
            "Rosa",
            "Amarilla"});
            this.cmbFlor.FormattingEnabled = true;
            this.cmbFlor.Items.AddRange(new object[] {
            "roja",
            "amarilla",
            "rosa"});
            this.cmbFlor.Location = new System.Drawing.Point(105, 318);
            this.cmbFlor.Name = "cmbFlor";
            this.cmbFlor.Size = new System.Drawing.Size(121, 23);
            this.cmbFlor.TabIndex = 10;
            // 
            // btnFlor
            // 
            this.btnFlor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnFlor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFlor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFlor.Location = new System.Drawing.Point(92, 346);
            this.btnFlor.Name = "btnFlor";
            this.btnFlor.Size = new System.Drawing.Size(149, 27);
            this.btnFlor.TabIndex = 11;
            this.btnFlor.Text = "Filtrar Flores";
            this.btnFlor.UseVisualStyleBackColor = false;
            this.btnFlor.Click += new System.EventHandler(this.btnFlor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Color de Flor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo de Fruto";
            // 
            // cmbFruto
            // 
            this.cmbFruto.AutoCompleteCustomSource.AddRange(new string[] {
            "Seco",
            "Carnoso"});
            this.cmbFruto.FormattingEnabled = true;
            this.cmbFruto.Items.AddRange(new object[] {
            "Seco",
            "Carnoso"});
            this.cmbFruto.Location = new System.Drawing.Point(365, 167);
            this.cmbFruto.Name = "cmbFruto";
            this.cmbFruto.Size = new System.Drawing.Size(121, 23);
            this.cmbFruto.TabIndex = 14;
            // 
            // btnFruto
            // 
            this.btnFruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnFruto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFruto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFruto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFruto.Location = new System.Drawing.Point(352, 196);
            this.btnFruto.Name = "btnFruto";
            this.btnFruto.Size = new System.Drawing.Size(149, 28);
            this.btnFruto.TabIndex = 15;
            this.btnFruto.Text = "Filtrar Frutos";
            this.btnFruto.UseVisualStyleBackColor = false;
            this.btnFruto.Click += new System.EventHandler(this.btnFruto_Click);
            // 
            // btnExportarFrutoTxt
            // 
            this.btnExportarFrutoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnExportarFrutoTxt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportarFrutoTxt.FlatAppearance.BorderSize = 2;
            this.btnExportarFrutoTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarFrutoTxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExportarFrutoTxt.Location = new System.Drawing.Point(352, 230);
            this.btnExportarFrutoTxt.Name = "btnExportarFrutoTxt";
            this.btnExportarFrutoTxt.Size = new System.Drawing.Size(149, 45);
            this.btnExportarFrutoTxt.TabIndex = 16;
            this.btnExportarFrutoTxt.Text = "Exportar Resultados Tipo Fruto";
            this.btnExportarFrutoTxt.UseVisualStyleBackColor = false;
            this.btnExportarFrutoTxt.Click += new System.EventHandler(this.btnExportarFrutoTxt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Altura Maxima";
            // 
            // cmbAltura
            // 
            this.cmbAltura.AutoCompleteCustomSource.AddRange(new string[] {
            "Con Fruto",
            "Sin Fruto"});
            this.cmbAltura.FormattingEnabled = true;
            this.cmbAltura.Items.AddRange(new object[] {
            "Con Fruto",
            "Sin Fruto"});
            this.cmbAltura.Location = new System.Drawing.Point(365, 316);
            this.cmbAltura.Name = "cmbAltura";
            this.cmbAltura.Size = new System.Drawing.Size(121, 23);
            this.cmbAltura.TabIndex = 19;
            // 
            // btnExportColorFlor
            // 
            this.btnExportColorFlor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnExportColorFlor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportColorFlor.FlatAppearance.BorderSize = 2;
            this.btnExportColorFlor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportColorFlor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExportColorFlor.Location = new System.Drawing.Point(92, 383);
            this.btnExportColorFlor.Name = "btnExportColorFlor";
            this.btnExportColorFlor.Size = new System.Drawing.Size(149, 45);
            this.btnExportColorFlor.TabIndex = 20;
            this.btnExportColorFlor.Text = "Exportar Resultados Color Flor";
            this.btnExportColorFlor.UseVisualStyleBackColor = false;
            this.btnExportColorFlor.Click += new System.EventHandler(this.btnExportColorFlor_Click);
            // 
            // btnExportOrigen
            // 
            this.btnExportOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnExportOrigen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportOrigen.FlatAppearance.BorderSize = 2;
            this.btnExportOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportOrigen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExportOrigen.Location = new System.Drawing.Point(92, 230);
            this.btnExportOrigen.Name = "btnExportOrigen";
            this.btnExportOrigen.Size = new System.Drawing.Size(149, 45);
            this.btnExportOrigen.TabIndex = 21;
            this.btnExportOrigen.Text = "Exportar Resultados De Origen";
            this.btnExportOrigen.UseVisualStyleBackColor = false;
            this.btnExportOrigen.Click += new System.EventHandler(this.btnExportOrigen_Click);
            // 
            // btnExportAlturaMax
            // 
            this.btnExportAlturaMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnExportAlturaMax.FlatAppearance.BorderSize = 2;
            this.btnExportAlturaMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAlturaMax.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExportAlturaMax.Location = new System.Drawing.Point(352, 383);
            this.btnExportAlturaMax.Name = "btnExportAlturaMax";
            this.btnExportAlturaMax.Size = new System.Drawing.Size(149, 45);
            this.btnExportAlturaMax.TabIndex = 22;
            this.btnExportAlturaMax.Text = "Exportar Resultados Altura Max";
            this.btnExportAlturaMax.UseVisualStyleBackColor = false;
            this.btnExportAlturaMax.Click += new System.EventHandler(this.btnExportAlturaMax_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(562, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "PLANTAS CON FRUTOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(562, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "PLANTAS SIN FRUTOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(562, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "PLANTAS MUSGOS";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(27, 610);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 19);
            this.lblMensaje.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(92, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Filtrar Origen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnOrigen_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(352, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 27);
            this.button3.TabIndex = 17;
            this.button3.Text = "Altura Maxima";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Musgo con Mayor cantidad de esporas";
            // 
            // btnExportEsporas
            // 
            this.btnExportEsporas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnExportEsporas.FlatAppearance.BorderSize = 2;
            this.btnExportEsporas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportEsporas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExportEsporas.Location = new System.Drawing.Point(221, 525);
            this.btnExportEsporas.Name = "btnExportEsporas";
            this.btnExportEsporas.Size = new System.Drawing.Size(149, 45);
            this.btnExportEsporas.TabIndex = 28;
            this.btnExportEsporas.Text = "Exportar Resultados Max Esporas";
            this.btnExportEsporas.UseVisualStyleBackColor = false;
            this.btnExportEsporas.Click += new System.EventHandler(this.btnExportEsporas_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(26, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 40);
            this.label9.TabIndex = 29;
            this.label9.Text = "Filtros y Reportes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(194)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1098, 699);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExportEsporas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExportAlturaMax);
            this.Controls.Add(this.btnExportOrigen);
            this.Controls.Add(this.btnExportColorFlor);
            this.Controls.Add(this.cmbAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExportarFrutoTxt);
            this.Controls.Add(this.btnFruto);
            this.Controls.Add(this.cmbFruto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFlor);
            this.Controls.Add(this.cmbFlor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEsporas);
            this.Controls.Add(this.dgvMusgos);
            this.Controls.Add(this.dgvSinFruto);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.dgvMostrarConFruto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOrigen);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFiltros";
            this.Load += new System.EventHandler(this.FrmFiltros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConFruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinFruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusgos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrigen;
        private System.Windows.Forms.DataGridView dgvMostrarConFruto;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.DataGridView dgvSinFruto;
        private System.Windows.Forms.DataGridView dgvMusgos;
        private System.Windows.Forms.Button btnEsporas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFlor;
        private System.Windows.Forms.Button btnFlor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFruto;
        private System.Windows.Forms.Button btnFruto;
        private System.Windows.Forms.Button btnExportarFrutoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAltura;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnExportColorFlor;
        private System.Windows.Forms.Button btnExportOrigen;
        private System.Windows.Forms.Button btnExportAlturaMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExportEsporas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}