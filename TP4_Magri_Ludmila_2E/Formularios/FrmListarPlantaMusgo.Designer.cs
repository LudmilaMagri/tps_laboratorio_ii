
namespace Formularios
{
    partial class FrmListarPlantaMusgo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarPlantaMusgo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPlanta = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvMusgo = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCantEsporas = new System.Windows.Forms.TextBox();
            this.txtCantidadAgua = new System.Windows.Forms.TextBox();
            this.txtCicloVida = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCatchNombre = new System.Windows.Forms.Label();
            this.lblCatchFamilia = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblCatchVida = new System.Windows.Forms.Label();
            this.lblCatchAgua = new System.Windows.Forms.Label();
            this.lblCatchEsporas = new System.Windows.Forms.Label();
            this.btnGuardarXml = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblEvento = new System.Windows.Forms.Label();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCargando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusgo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Id de Planta";
            // 
            // txtIdPlanta
            // 
            this.txtIdPlanta.Enabled = false;
            this.txtIdPlanta.Location = new System.Drawing.Point(148, 56);
            this.txtIdPlanta.Name = "txtIdPlanta";
            this.txtIdPlanta.Size = new System.Drawing.Size(121, 23);
            this.txtIdPlanta.TabIndex = 52;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(37, 539);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 15);
            this.lblMensaje.TabIndex = 51;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(163)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(503, 332);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(288, 29);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(163)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(125, 406);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 41);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GuardarEdit";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarEdit_Click);
            // 
            // dgvMusgo
            // 
            this.dgvMusgo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusgo.Location = new System.Drawing.Point(296, 87);
            this.dgvMusgo.Name = "dgvMusgo";
            this.dgvMusgo.ReadOnly = true;
            this.dgvMusgo.RowTemplate.Height = 25;
            this.dgvMusgo.Size = new System.Drawing.Size(678, 239);
            this.dgvMusgo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cantidad de Esporas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Cantidad de agua/año";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "Ciclo de Vida";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 40;
            this.label12.Text = "Origen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 39;
            this.label13.Text = "Familia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "Nombre";
            // 
            // txtCantEsporas
            // 
            this.txtCantEsporas.Location = new System.Drawing.Point(147, 320);
            this.txtCantEsporas.Name = "txtCantEsporas";
            this.txtCantEsporas.Size = new System.Drawing.Size(121, 23);
            this.txtCantEsporas.TabIndex = 6;
            // 
            // txtCantidadAgua
            // 
            this.txtCantidadAgua.Location = new System.Drawing.Point(147, 274);
            this.txtCantidadAgua.Name = "txtCantidadAgua";
            this.txtCantidadAgua.Size = new System.Drawing.Size(121, 23);
            this.txtCantidadAgua.TabIndex = 5;
            // 
            // txtCicloVida
            // 
            this.txtCicloVida.Location = new System.Drawing.Point(147, 229);
            this.txtCicloVida.Name = "txtCicloVida";
            this.txtCicloVida.Size = new System.Drawing.Size(121, 23);
            this.txtCicloVida.TabIndex = 4;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(147, 186);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(121, 23);
            this.txtOrigen.TabIndex = 3;
            // 
            // txtFamilia
            // 
            this.txtFamilia.Location = new System.Drawing.Point(147, 142);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(121, 23);
            this.txtFamilia.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(163)))));
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlta.Location = new System.Drawing.Point(18, 406);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(77, 41);
            this.btnAlta.TabIndex = 7;
            this.btnAlta.Text = "Agregar Planta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(172)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 44);
            this.panel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(147, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "(Briofitas)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 40);
            this.label2.TabIndex = 30;
            this.label2.Text = "Musgos";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(951, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(163)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(228, 406);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 41);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(163)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(102, 473);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 42);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblCatchNombre
            // 
            this.lblCatchNombre.AutoSize = true;
            this.lblCatchNombre.ForeColor = System.Drawing.Color.Red;
            this.lblCatchNombre.Location = new System.Drawing.Point(147, 124);
            this.lblCatchNombre.Name = "lblCatchNombre";
            this.lblCatchNombre.Size = new System.Drawing.Size(0, 15);
            this.lblCatchNombre.TabIndex = 57;
            // 
            // lblCatchFamilia
            // 
            this.lblCatchFamilia.AutoSize = true;
            this.lblCatchFamilia.ForeColor = System.Drawing.Color.Red;
            this.lblCatchFamilia.Location = new System.Drawing.Point(147, 168);
            this.lblCatchFamilia.Name = "lblCatchFamilia";
            this.lblCatchFamilia.Size = new System.Drawing.Size(0, 15);
            this.lblCatchFamilia.TabIndex = 58;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.ForeColor = System.Drawing.Color.Red;
            this.lblOrigen.Location = new System.Drawing.Point(147, 211);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(0, 15);
            this.lblOrigen.TabIndex = 59;
            // 
            // lblCatchVida
            // 
            this.lblCatchVida.AutoSize = true;
            this.lblCatchVida.ForeColor = System.Drawing.Color.Red;
            this.lblCatchVida.Location = new System.Drawing.Point(147, 255);
            this.lblCatchVida.Name = "lblCatchVida";
            this.lblCatchVida.Size = new System.Drawing.Size(0, 15);
            this.lblCatchVida.TabIndex = 60;
            // 
            // lblCatchAgua
            // 
            this.lblCatchAgua.AutoSize = true;
            this.lblCatchAgua.ForeColor = System.Drawing.Color.Red;
            this.lblCatchAgua.Location = new System.Drawing.Point(147, 300);
            this.lblCatchAgua.Name = "lblCatchAgua";
            this.lblCatchAgua.Size = new System.Drawing.Size(0, 15);
            this.lblCatchAgua.TabIndex = 61;
            // 
            // lblCatchEsporas
            // 
            this.lblCatchEsporas.AutoSize = true;
            this.lblCatchEsporas.ForeColor = System.Drawing.Color.Red;
            this.lblCatchEsporas.Location = new System.Drawing.Point(147, 346);
            this.lblCatchEsporas.Name = "lblCatchEsporas";
            this.lblCatchEsporas.Size = new System.Drawing.Size(0, 15);
            this.lblCatchEsporas.TabIndex = 62;
            // 
            // btnGuardarXml
            // 
            this.btnGuardarXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(163)))));
            this.btnGuardarXml.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardarXml.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarXml.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardarXml.Location = new System.Drawing.Point(696, 389);
            this.btnGuardarXml.Name = "btnGuardarXml";
            this.btnGuardarXml.Size = new System.Drawing.Size(149, 43);
            this.btnGuardarXml.TabIndex = 13;
            this.btnGuardarXml.Text = "Guardar Cambios XML";
            this.btnGuardarXml.UseVisualStyleBackColor = false;
            this.btnGuardarXml.Click += new System.EventHandler(this.btnGuardarXml_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(163)))));
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardarCambios.Location = new System.Drawing.Point(425, 390);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(149, 42);
            this.btnGuardarCambios.TabIndex = 12;
            this.btnGuardarCambios.Text = "Guardar Cambios Json";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click_1);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEvento.Location = new System.Drawing.Point(492, 443);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(0, 21);
            this.lblEvento.TabIndex = 63;
            // 
            // pb5
            // 
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(747, 472);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(148, 92);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 75;
            this.pb5.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(655, 486);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(106, 65);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 74;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(568, 486);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(106, 65);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 73;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(485, 491);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(106, 65);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 72;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(406, 499);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(106, 65);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 71;
            this.pb1.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(296, 56);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(107, 30);
            this.btnActualizar.TabIndex = 78;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCargando.Location = new System.Drawing.Point(503, 56);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(0, 25);
            this.lblCargando.TabIndex = 79;
            // 
            // FrmListarPlantaMusgo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 590);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.btnGuardarXml);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblCatchEsporas);
            this.Controls.Add(this.lblCatchAgua);
            this.Controls.Add(this.lblCatchVida);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblCatchFamilia);
            this.Controls.Add(this.lblCatchNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdPlanta);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvMusgo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCantEsporas);
            this.Controls.Add(this.txtCantidadAgua);
            this.Controls.Add(this.txtCicloVida);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtFamilia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListarPlantaMusgo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musgos";
            this.Load += new System.EventHandler(this.FrmListarPlantaMusgo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusgo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPlanta;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvMusgo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCantEsporas;
        private System.Windows.Forms.TextBox txtCantidadAgua;
        private System.Windows.Forms.TextBox txtCicloVida;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCatchNombre;
        private System.Windows.Forms.Label lblCatchFamilia;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblCatchVida;
        private System.Windows.Forms.Label lblCatchAgua;
        private System.Windows.Forms.Label lblCatchEsporas;
        private System.Windows.Forms.Button btnGuardarXml;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblCargando;
    }
}