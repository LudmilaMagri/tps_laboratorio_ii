
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoPlanta = new System.Windows.Forms.ComboBox();
            this.btnExportPorcentaje = new System.Windows.Forms.Button();
            this.btnPorcentajeTipoPlanta = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbReporteFruto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.Label();
            this.btnReporteFruto = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReporteColor = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.cmbReporteColor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConFruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinFruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusgos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrigen
            // 
            this.btnOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnOrigen.FlatAppearance.BorderSize = 0;
            this.btnOrigen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnOrigen.Location = new System.Drawing.Point(102, 131);
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
            this.dgvMostrarConFruto.Location = new System.Drawing.Point(833, 74);
            this.dgvMostrarConFruto.Name = "dgvMostrarConFruto";
            this.dgvMostrarConFruto.ReadOnly = true;
            this.dgvMostrarConFruto.RowTemplate.Height = 25;
            this.dgvMostrarConFruto.Size = new System.Drawing.Size(507, 162);
            this.dgvMostrarConFruto.TabIndex = 15;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "Nativa",
            "America",
            "Europa",
            "Asia"});
            this.cmbOrigen.Location = new System.Drawing.Point(102, 102);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 23);
            this.cmbOrigen.TabIndex = 1;
            // 
            // dgvSinFruto
            // 
            this.dgvSinFruto.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvSinFruto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinFruto.Location = new System.Drawing.Point(833, 295);
            this.dgvSinFruto.Name = "dgvSinFruto";
            this.dgvSinFruto.ReadOnly = true;
            this.dgvSinFruto.RowTemplate.Height = 25;
            this.dgvSinFruto.Size = new System.Drawing.Size(507, 162);
            this.dgvSinFruto.TabIndex = 16;
            // 
            // dgvMusgos
            // 
            this.dgvMusgos.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvMusgos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusgos.Location = new System.Drawing.Point(833, 507);
            this.dgvMusgos.Name = "dgvMusgos";
            this.dgvMusgos.ReadOnly = true;
            this.dgvMusgos.RowTemplate.Height = 25;
            this.dgvMusgos.Size = new System.Drawing.Size(507, 162);
            this.dgvMusgos.TabIndex = 17;
            // 
            // btnEsporas
            // 
            this.btnEsporas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnEsporas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEsporas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsporas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEsporas.Location = new System.Drawing.Point(615, 282);
            this.btnEsporas.Name = "btnEsporas";
            this.btnEsporas.Size = new System.Drawing.Size(149, 29);
            this.btnEsporas.TabIndex = 13;
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
            this.panel1.Size = new System.Drawing.Size(1366, 38);
            this.panel1.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1327, 9);
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
            this.label1.Location = new System.Drawing.Point(43, 105);
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
            this.cmbFlor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlor.FormattingEnabled = true;
            this.cmbFlor.Items.AddRange(new object[] {
            "roja",
            "amarilla",
            "rosa"});
            this.cmbFlor.Location = new System.Drawing.Point(102, 256);
            this.cmbFlor.Name = "cmbFlor";
            this.cmbFlor.Size = new System.Drawing.Size(121, 23);
            this.cmbFlor.TabIndex = 7;
            // 
            // btnFlor
            // 
            this.btnFlor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnFlor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFlor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFlor.Location = new System.Drawing.Point(89, 284);
            this.btnFlor.Name = "btnFlor";
            this.btnFlor.Size = new System.Drawing.Size(149, 27);
            this.btnFlor.TabIndex = 8;
            this.btnFlor.Text = "Filtrar Flores";
            this.btnFlor.UseVisualStyleBackColor = false;
            this.btnFlor.Click += new System.EventHandler(this.btnFlor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Color de Flor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 106);
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
            this.cmbFruto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFruto.FormattingEnabled = true;
            this.cmbFruto.Items.AddRange(new object[] {
            "Seco",
            "Carnoso"});
            this.cmbFruto.Location = new System.Drawing.Point(362, 102);
            this.cmbFruto.Name = "cmbFruto";
            this.cmbFruto.Size = new System.Drawing.Size(121, 23);
            this.cmbFruto.TabIndex = 4;
            // 
            // btnFruto
            // 
            this.btnFruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnFruto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFruto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFruto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFruto.Location = new System.Drawing.Point(349, 131);
            this.btnFruto.Name = "btnFruto";
            this.btnFruto.Size = new System.Drawing.Size(149, 28);
            this.btnFruto.TabIndex = 5;
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
            this.btnExportarFrutoTxt.Location = new System.Drawing.Point(349, 165);
            this.btnExportarFrutoTxt.Name = "btnExportarFrutoTxt";
            this.btnExportarFrutoTxt.Size = new System.Drawing.Size(149, 45);
            this.btnExportarFrutoTxt.TabIndex = 6;
            this.btnExportarFrutoTxt.Text = "Exportar Resultados Tipo Fruto";
            this.btnExportarFrutoTxt.UseVisualStyleBackColor = false;
            this.btnExportarFrutoTxt.Click += new System.EventHandler(this.btnExportarFrutoTxt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 102);
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
            this.cmbAltura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAltura.FormattingEnabled = true;
            this.cmbAltura.Items.AddRange(new object[] {
            "Con Fruto",
            "Sin Fruto"});
            this.cmbAltura.Location = new System.Drawing.Point(628, 98);
            this.cmbAltura.Name = "cmbAltura";
            this.cmbAltura.Size = new System.Drawing.Size(121, 23);
            this.cmbAltura.TabIndex = 10;
            // 
            // btnExportColorFlor
            // 
            this.btnExportColorFlor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnExportColorFlor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportColorFlor.FlatAppearance.BorderSize = 2;
            this.btnExportColorFlor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportColorFlor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExportColorFlor.Location = new System.Drawing.Point(89, 321);
            this.btnExportColorFlor.Name = "btnExportColorFlor";
            this.btnExportColorFlor.Size = new System.Drawing.Size(149, 45);
            this.btnExportColorFlor.TabIndex = 9;
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
            this.btnExportOrigen.Location = new System.Drawing.Point(89, 165);
            this.btnExportOrigen.Name = "btnExportOrigen";
            this.btnExportOrigen.Size = new System.Drawing.Size(149, 45);
            this.btnExportOrigen.TabIndex = 3;
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
            this.btnExportAlturaMax.Location = new System.Drawing.Point(615, 165);
            this.btnExportAlturaMax.Name = "btnExportAlturaMax";
            this.btnExportAlturaMax.Size = new System.Drawing.Size(149, 45);
            this.btnExportAlturaMax.TabIndex = 12;
            this.btnExportAlturaMax.Text = "Exportar Resultados Altura Max";
            this.btnExportAlturaMax.UseVisualStyleBackColor = false;
            this.btnExportAlturaMax.Click += new System.EventHandler(this.btnExportAlturaMax_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(833, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "PLANTAS CON FRUTOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(833, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "PLANTAS SIN FRUTOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(833, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "PLANTAS MUSGOS";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(24, 602);
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
            this.button1.Location = new System.Drawing.Point(89, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 25);
            this.button1.TabIndex = 2;
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
            this.button3.Location = new System.Drawing.Point(615, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 27);
            this.button3.TabIndex = 11;
            this.button3.Text = "Altura Maxima";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(637, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 30);
            this.label8.TabIndex = 27;
            this.label8.Text = "Musgo con Mayor \r\ncantidad de esporas";
            // 
            // btnExportEsporas
            // 
            this.btnExportEsporas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnExportEsporas.FlatAppearance.BorderSize = 2;
            this.btnExportEsporas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportEsporas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExportEsporas.Location = new System.Drawing.Point(615, 317);
            this.btnExportEsporas.Name = "btnExportEsporas";
            this.btnExportEsporas.Size = new System.Drawing.Size(149, 45);
            this.btnExportEsporas.TabIndex = 14;
            this.btnExportEsporas.Text = "Exportar Resultados Max Esporas";
            this.btnExportEsporas.UseVisualStyleBackColor = false;
            this.btnExportEsporas.Click += new System.EventHandler(this.btnExportEsporas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(296, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 40);
            this.label9.TabIndex = 29;
            this.label9.Text = "Filtros ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tipo de Planta";
            // 
            // cmbTipoPlanta
            // 
            this.cmbTipoPlanta.AutoCompleteCustomSource.AddRange(new string[] {
            "Con Fruto",
            "Sin Fruto",
            "Musgo"});
            this.cmbTipoPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPlanta.FormattingEnabled = true;
            this.cmbTipoPlanta.Items.AddRange(new object[] {
            "Con Fruto",
            "Sin Fruto",
            "Musgo"});
            this.cmbTipoPlanta.Location = new System.Drawing.Point(362, 249);
            this.cmbTipoPlanta.Name = "cmbTipoPlanta";
            this.cmbTipoPlanta.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoPlanta.TabIndex = 32;
            // 
            // btnExportPorcentaje
            // 
            this.btnExportPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnExportPorcentaje.FlatAppearance.BorderSize = 2;
            this.btnExportPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPorcentaje.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExportPorcentaje.Location = new System.Drawing.Point(349, 321);
            this.btnExportPorcentaje.Name = "btnExportPorcentaje";
            this.btnExportPorcentaje.Size = new System.Drawing.Size(149, 45);
            this.btnExportPorcentaje.TabIndex = 34;
            this.btnExportPorcentaje.Text = "Exportar Resultados Porcentaje";
            this.btnExportPorcentaje.UseVisualStyleBackColor = false;
            this.btnExportPorcentaje.Click += new System.EventHandler(this.btnExportPorcentaje_Click);
            // 
            // btnPorcentajeTipoPlanta
            // 
            this.btnPorcentajeTipoPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnPorcentajeTipoPlanta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPorcentajeTipoPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentajeTipoPlanta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPorcentajeTipoPlanta.Location = new System.Drawing.Point(349, 284);
            this.btnPorcentajeTipoPlanta.Name = "btnPorcentajeTipoPlanta";
            this.btnPorcentajeTipoPlanta.Size = new System.Drawing.Size(149, 27);
            this.btnPorcentajeTipoPlanta.TabIndex = 33;
            this.btnPorcentajeTipoPlanta.Text = "Porcentaje";
            this.btnPorcentajeTipoPlanta.UseVisualStyleBackColor = false;
            this.btnPorcentajeTipoPlanta.Click += new System.EventHandler(this.btnPorcentajeTipoPlanta_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRefresh.Location = new System.Drawing.Point(892, 689);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(409, 29);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbReporteFruto
            // 
            this.cmbReporteFruto.AutoCompleteCustomSource.AddRange(new string[] {
            "Seco",
            "Carnoso"});
            this.cmbReporteFruto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporteFruto.FormattingEnabled = true;
            this.cmbReporteFruto.Items.AddRange(new object[] {
            "Seco",
            "Carnoso"});
            this.cmbReporteFruto.Location = new System.Drawing.Point(162, 474);
            this.cmbReporteFruto.Name = "cmbReporteFruto";
            this.cmbReporteFruto.Size = new System.Drawing.Size(121, 23);
            this.cmbReporteFruto.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Tipo de Fruto";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(162, 517);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(121, 23);
            this.txtAltura.TabIndex = 39;
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(99, 525);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(39, 15);
            this.Altura.TabIndex = 40;
            this.Altura.Text = "Altura";
            // 
            // btnReporteFruto
            // 
            this.btnReporteFruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnReporteFruto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReporteFruto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteFruto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnReporteFruto.Location = new System.Drawing.Point(162, 560);
            this.btnReporteFruto.Name = "btnReporteFruto";
            this.btnReporteFruto.Size = new System.Drawing.Size(121, 28);
            this.btnReporteFruto.TabIndex = 41;
            this.btnReporteFruto.Text = "Seleccionar";
            this.btnReporteFruto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporteFruto.UseVisualStyleBackColor = false;
            this.btnReporteFruto.Click += new System.EventHandler(this.btnReporteFruto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(296, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 40);
            this.label12.TabIndex = 42;
            this.label12.Text = "Reportes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 394);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // btnReporteColor
            // 
            this.btnReporteColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(192)))), ((int)(((byte)(148)))));
            this.btnReporteColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReporteColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteColor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnReporteColor.Location = new System.Drawing.Point(515, 560);
            this.btnReporteColor.Name = "btnReporteColor";
            this.btnReporteColor.Size = new System.Drawing.Size(121, 28);
            this.btnReporteColor.TabIndex = 48;
            this.btnReporteColor.Text = "Seleccionar";
            this.btnReporteColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporteColor.UseVisualStyleBackColor = false;
            this.btnReporteColor.Click += new System.EventHandler(this.btnReporteColor_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(407, 520);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 15);
            this.label13.TabIndex = 47;
            this.label13.Text = "Cantidad de Agua";
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(515, 517);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(121, 23);
            this.txtAgua.TabIndex = 46;
            // 
            // cmbReporteColor
            // 
            this.cmbReporteColor.AutoCompleteCustomSource.AddRange(new string[] {
            "Seco",
            "Carnoso"});
            this.cmbReporteColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporteColor.FormattingEnabled = true;
            this.cmbReporteColor.Items.AddRange(new object[] {
            "roja",
            "amarilla",
            "rosa"});
            this.cmbReporteColor.Location = new System.Drawing.Point(515, 474);
            this.cmbReporteColor.Name = "cmbReporteColor";
            this.cmbReporteColor.Size = new System.Drawing.Size(121, 23);
            this.cmbReporteColor.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(422, 477);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 45;
            this.label14.Text = "Color de Flor";
            // 
            // FrmFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(194)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1366, 742);
            this.Controls.Add(this.btnReporteColor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAgua);
            this.Controls.Add(this.cmbReporteColor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnReporteFruto);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.cmbReporteFruto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExportPorcentaje);
            this.Controls.Add(this.btnPorcentajeTipoPlanta);
            this.Controls.Add(this.cmbTipoPlanta);
            this.Controls.Add(this.label10);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros";
            this.Load += new System.EventHandler(this.FrmFiltros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConFruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinFruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusgos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoPlanta;
        private System.Windows.Forms.Button btnExportPorcentaje;
        private System.Windows.Forms.Button btnPorcentajeTipoPlanta;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbReporteFruto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.Button btnReporteFruto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnReporteColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.ComboBox cmbReporteColor;
        private System.Windows.Forms.Label label14;
    }
}