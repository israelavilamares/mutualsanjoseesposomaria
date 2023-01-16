
namespace mutualsanjoseesposomaria
{
    partial class beneficiarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(beneficiarios));
            this.label1 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.fecha_ingresotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.parentescoctx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sexocxt = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actulizar = new System.Windows.Forms.Button();
            this.eliminarnumerofacturatxt = new System.Windows.Forms.TextBox();
            this.eliminanumerofacturabutton = new System.Windows.Forms.Button();
            this.numerosocioeliminartxt = new System.Windows.Forms.TextBox();
            this.eliminarnumerosociobutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numbeneficiario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchnumerosocioeliminartxt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.edadtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edadbton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.orgabox3 = new System.Windows.Forms.ComboBox();
            this.organbox2 = new System.Windows.Forms.ComboBox();
            this.orgarbox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 44);
            this.label1.TabIndex = 19;
            this.label1.Text = "\r\nNUMERO DE SOCIO";
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(226, 158);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(171, 26);
            this.idtxt.TabIndex = 20;
            this.idtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idtxt_KeyPress);
            this.idtxt.Validating += new System.ComponentModel.CancelEventHandler(this.idtxt_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "NOMBRE COMPLETO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombretxt
            // 
            this.nombretxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombretxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretxt.Location = new System.Drawing.Point(226, 211);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(171, 26);
            this.nombretxt.TabIndex = 22;
            this.nombretxt.Validating += new System.ComponentModel.CancelEventHandler(this.nombretxt_Validating);
            // 
            // agregar
            // 
            this.agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.agregar.BackgroundImage = global::mutualsanjoseesposomaria.Properties.Resources.descarga;
            this.agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(543, 278);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(89, 82);
            this.agregar.TabIndex = 23;
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // fecha_ingresotxt
            // 
            this.fecha_ingresotxt.AccessibleDescription = "";
            this.fecha_ingresotxt.AccessibleName = "";
            this.fecha_ingresotxt.Enabled = false;
            this.fecha_ingresotxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_ingresotxt.ForeColor = System.Drawing.Color.DarkGray;
            this.fecha_ingresotxt.Location = new System.Drawing.Point(228, 264);
            this.fecha_ingresotxt.Name = "fecha_ingresotxt";
            this.fecha_ingresotxt.Size = new System.Drawing.Size(169, 26);
            this.fecha_ingresotxt.TabIndex = 25;
            this.fecha_ingresotxt.Tag = "";
            this.fecha_ingresotxt.Text = "FECHA AUTOMATICA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "FECHA DE INGRESO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "PARENTESCO";
            // 
            // parentescoctx
            // 
            this.parentescoctx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parentescoctx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentescoctx.FormattingEnabled = true;
            this.parentescoctx.Items.AddRange(new object[] {
            "HIJO",
            "HIJA",
            "CONYUGUE",
            "NINGUNO"});
            this.parentescoctx.Location = new System.Drawing.Point(226, 311);
            this.parentescoctx.Name = "parentescoctx";
            this.parentescoctx.Size = new System.Drawing.Size(161, 27);
            this.parentescoctx.TabIndex = 27;
            this.parentescoctx.Validating += new System.ComponentModel.CancelEventHandler(this.parentescoctx_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "SEXO";
            // 
            // sexocxt
            // 
            this.sexocxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sexocxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sexocxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexocxt.FormattingEnabled = true;
            this.sexocxt.Items.AddRange(new object[] {
            "HOMBRE",
            "MUJER",
            "NINGUNO"});
            this.sexocxt.Location = new System.Drawing.Point(228, 362);
            this.sexocxt.Name = "sexocxt";
            this.sexocxt.Size = new System.Drawing.Size(109, 27);
            this.sexocxt.TabIndex = 29;
            this.sexocxt.Validating += new System.ComponentModel.CancelEventHandler(this.sexocxt_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 38);
            this.panel1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(391, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "DATOS DE BENEFICIARIOS";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 564);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 173);
            this.dataGridView1.TabIndex = 31;
            // 
            // actulizar
            // 
            this.actulizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actulizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actulizar.FlatAppearance.BorderSize = 0;
            this.actulizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actulizar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.actulizar.Image = global::mutualsanjoseesposomaria.Properties.Resources.descarga__2_;
            this.actulizar.Location = new System.Drawing.Point(415, 461);
            this.actulizar.Name = "actulizar";
            this.actulizar.Size = new System.Drawing.Size(118, 97);
            this.actulizar.TabIndex = 85;
            this.actulizar.Text = "ACTULIZAR TABLA";
            this.actulizar.UseVisualStyleBackColor = true;
            this.actulizar.Click += new System.EventHandler(this.actulizar_Click);
            // 
            // eliminarnumerofacturatxt
            // 
            this.eliminarnumerofacturatxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarnumerofacturatxt.ForeColor = System.Drawing.Color.DarkGray;
            this.eliminarnumerofacturatxt.Location = new System.Drawing.Point(837, 307);
            this.eliminarnumerofacturatxt.Name = "eliminarnumerofacturatxt";
            this.eliminarnumerofacturatxt.Size = new System.Drawing.Size(211, 26);
            this.eliminarnumerofacturatxt.TabIndex = 89;
            this.eliminarnumerofacturatxt.Text = "NUMERO BENEFICIARIO";
            this.eliminarnumerofacturatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eliminarnumerofacturatxt.Enter += new System.EventHandler(this.eliminarnumerofacturatxt_Enter);
            this.eliminarnumerofacturatxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eliminarnumerofacturatxt_KeyPress);
            this.eliminarnumerofacturatxt.Leave += new System.EventHandler(this.eliminarnumerofacturatxt_Leave);
            this.eliminarnumerofacturatxt.Validating += new System.ComponentModel.CancelEventHandler(this.eliminarnumerofacturatxt_Validating);
            // 
            // eliminanumerofacturabutton
            // 
            this.eliminanumerofacturabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.eliminanumerofacturabutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminanumerofacturabutton.Location = new System.Drawing.Point(699, 256);
            this.eliminanumerofacturabutton.Name = "eliminanumerofacturabutton";
            this.eliminanumerofacturabutton.Size = new System.Drawing.Size(132, 77);
            this.eliminanumerofacturabutton.TabIndex = 88;
            this.eliminanumerofacturabutton.Text = "ELIMINAR UN BENEFICIARIO";
            this.eliminanumerofacturabutton.UseVisualStyleBackColor = false;
            this.eliminanumerofacturabutton.Click += new System.EventHandler(this.eliminanumerofacturabutton_Click);
            // 
            // numerosocioeliminartxt
            // 
            this.numerosocioeliminartxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerosocioeliminartxt.ForeColor = System.Drawing.Color.DarkGray;
            this.numerosocioeliminartxt.Location = new System.Drawing.Point(829, 163);
            this.numerosocioeliminartxt.Name = "numerosocioeliminartxt";
            this.numerosocioeliminartxt.Size = new System.Drawing.Size(219, 26);
            this.numerosocioeliminartxt.TabIndex = 87;
            this.numerosocioeliminartxt.Text = "NUMERO DEL SOCIO";
            this.numerosocioeliminartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numerosocioeliminartxt.Enter += new System.EventHandler(this.numerosocioeliminartxt_Enter);
            this.numerosocioeliminartxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerosocioeliminartxt_KeyPress);
            this.numerosocioeliminartxt.Leave += new System.EventHandler(this.numerosocioeliminartxt_Leave);
            this.numerosocioeliminartxt.Validating += new System.ComponentModel.CancelEventHandler(this.numerosocioeliminartxt_Validating);
            // 
            // eliminarnumerosociobutton
            // 
            this.eliminarnumerosociobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.eliminarnumerosociobutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarnumerosociobutton.Location = new System.Drawing.Point(695, 102);
            this.eliminarnumerosociobutton.Name = "eliminarnumerosociobutton";
            this.eliminarnumerosociobutton.Size = new System.Drawing.Size(128, 87);
            this.eliminarnumerosociobutton.TabIndex = 86;
            this.eliminarnumerosociobutton.Text = "ELIMINAR TODOS BEFICIARIOS ";
            this.eliminarnumerosociobutton.UseVisualStyleBackColor = false;
            this.eliminarnumerosociobutton.Click += new System.EventHandler(this.eliminarnumerosociobutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 44);
            this.label7.TabIndex = 90;
            this.label7.Text = "\r\nNUMERO DE BENEFICIARIO";
            // 
            // numbeneficiario
            // 
            this.numbeneficiario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbeneficiario.Location = new System.Drawing.Point(280, 117);
            this.numbeneficiario.Name = "numbeneficiario";
            this.numbeneficiario.Size = new System.Drawing.Size(171, 26);
            this.numbeneficiario.TabIndex = 91;
            this.numbeneficiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numbeneficiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbeneficiario_KeyPress);
            this.numbeneficiario.Validating += new System.ComponentModel.CancelEventHandler(this.numbeneficiario_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 22);
            this.label8.TabIndex = 93;
            this.label8.Text = "FECHA DE NACIMIENTO";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::mutualsanjoseesposomaria.Properties.Resources.buscar;
            this.button1.Location = new System.Drawing.Point(942, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 107);
            this.button1.TabIndex = 96;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchnumerosocioeliminartxt
            // 
            this.searchnumerosocioeliminartxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchnumerosocioeliminartxt.ForeColor = System.Drawing.Color.DarkGray;
            this.searchnumerosocioeliminartxt.Location = new System.Drawing.Point(717, 532);
            this.searchnumerosocioeliminartxt.Name = "searchnumerosocioeliminartxt";
            this.searchnumerosocioeliminartxt.Size = new System.Drawing.Size(219, 26);
            this.searchnumerosocioeliminartxt.TabIndex = 97;
            this.searchnumerosocioeliminartxt.Text = "NUMERO DEL SOCIO";
            this.searchnumerosocioeliminartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchnumerosocioeliminartxt.Enter += new System.EventHandler(this.searchnumerosocioeliminartxt_Enter);
            this.searchnumerosocioeliminartxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchnumerosocioeliminartxt_KeyPress);
            this.searchnumerosocioeliminartxt.Leave += new System.EventHandler(this.searchnumerosocioeliminartxt_Leave);
            this.searchnumerosocioeliminartxt.Validating += new System.ComponentModel.CancelEventHandler(this.searchnumerosocioeliminartxt_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // edadtxt
            // 
            this.edadtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edadtxt.Cursor = System.Windows.Forms.Cursors.No;
            this.edadtxt.Enabled = false;
            this.edadtxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadtxt.Location = new System.Drawing.Point(107, 480);
            this.edadtxt.Name = "edadtxt";
            this.edadtxt.Size = new System.Drawing.Size(80, 26);
            this.edadtxt.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 22);
            this.label9.TabIndex = 99;
            this.label9.Text = "EDAD";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edadbton
            // 
            this.edadbton.BackColor = System.Drawing.Color.YellowGreen;
            this.edadbton.FlatAppearance.BorderSize = 0;
            this.edadbton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.edadbton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.edadbton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edadbton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadbton.Location = new System.Drawing.Point(255, 508);
            this.edadbton.Name = "edadbton";
            this.edadbton.Size = new System.Drawing.Size(132, 50);
            this.edadbton.TabIndex = 103;
            this.edadbton.Text = "EDADES ACTUALES";
            this.edadbton.UseVisualStyleBackColor = false;
            this.edadbton.Click += new System.EventHandler(this.edadbton_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(246, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 22);
            this.label10.TabIndex = 104;
            this.label10.Text = "DIA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(356, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 22);
            this.label11.TabIndex = 106;
            this.label11.Text = "MES";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(477, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 22);
            this.label12.TabIndex = 108;
            this.label12.Text = "AÑO ";
            // 
            // orgabox3
            // 
            this.orgabox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgabox3.FormattingEnabled = true;
            this.orgabox3.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.orgabox3.Location = new System.Drawing.Point(293, 418);
            this.orgabox3.Name = "orgabox3";
            this.orgabox3.Size = new System.Drawing.Size(56, 26);
            this.orgabox3.TabIndex = 109;
            // 
            // organbox2
            // 
            this.organbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organbox2.FormattingEnabled = true;
            this.organbox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.organbox2.Location = new System.Drawing.Point(415, 418);
            this.organbox2.Name = "organbox2";
            this.organbox2.Size = new System.Drawing.Size(56, 26);
            this.organbox2.TabIndex = 110;
            // 
            // orgarbox1
            // 
            this.orgarbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgarbox1.FormattingEnabled = true;
            this.orgarbox1.Items.AddRange(new object[] {
            "1890",
            "1891",
            "1892",
            "1893",
            "1894",
            "1895",
            "1896",
            "1897",
            "1898",
            "1899",
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099",
            "2100",
            "2101",
            "2102",
            "2103",
            "2104",
            "2105",
            "2106",
            "2107",
            "2108",
            "2109",
            "2110",
            "2111",
            "2112",
            "2113",
            "2114",
            "2115",
            "2116",
            "2117",
            "2118",
            "2119",
            "2120",
            "2121",
            "2122",
            "2123",
            "2124",
            "2125",
            "2126",
            "2127",
            "2128",
            "2129",
            "2130",
            "2131",
            "2132",
            "2133",
            "2134",
            "2135",
            "2136",
            "2137",
            "2138",
            "2139",
            "2140",
            "2141",
            "2142",
            "2143",
            "2144",
            "2145",
            "2146",
            "2147",
            "2148",
            "2149",
            "2150",
            "2151",
            "2152",
            "2153",
            "2154",
            "2155",
            "2156",
            "2157",
            "2158",
            "2159",
            "2160",
            "2161",
            "2162",
            "2163",
            "2164",
            "2165",
            "2166",
            "2167",
            "2168",
            "2169",
            "2170",
            "2171",
            "2172",
            "2173",
            "2174",
            "2175",
            "2176",
            "2177",
            "2178",
            "2179",
            "2180",
            "2181",
            "2182",
            "2183",
            "2184",
            "2185",
            "2186",
            "2187",
            "2188",
            "2189",
            "2190",
            "2191",
            "2192",
            "2193",
            "2194",
            "2195",
            "2196",
            "2197",
            "2198",
            "2199",
            "2200",
            "2201",
            "2202",
            "2203",
            "2204",
            "2205",
            "2206",
            "2207",
            "2208",
            "2209",
            "2210",
            "2211",
            "2212",
            "2213",
            "2214",
            "2215",
            "2216",
            "2217",
            "2218",
            "2219",
            "2220",
            "2221",
            "2222",
            "2223",
            "2224",
            "2225",
            "2226",
            "2227",
            "2228",
            "2229",
            "2230",
            "2231",
            "2232",
            "2233",
            "2234",
            "2235",
            "2236",
            "2237",
            "2238",
            "2239",
            "2240",
            "2241",
            "2242",
            "2243",
            "2244",
            "2245",
            "2246",
            "2247",
            "2248",
            "2249",
            "2250",
            "2251",
            "2252",
            "2253",
            "2254",
            "2255",
            "2256",
            "2257",
            "2258",
            "2259",
            "2260",
            "2261",
            "2262",
            "2263",
            "2264",
            "2265",
            "2266",
            "2267",
            "2268",
            "2269",
            "2270",
            "2271",
            "2272",
            "2273",
            "2274",
            "2275",
            "2276",
            "2277",
            "2278",
            "2279",
            "2280",
            "2281",
            "2282",
            "2283",
            "2284",
            "2285",
            "2286",
            "2287",
            "2288",
            "2289",
            "2290",
            "2291",
            "2292",
            "2293",
            "2294",
            "2295",
            "2296",
            "2297",
            "2298",
            "2299",
            "2300",
            "2301",
            "2302",
            "2303",
            "2304",
            "2305",
            "2306",
            "2307",
            "2308",
            "2309",
            "2310",
            "2311",
            "2312",
            "2313",
            "2314",
            "2315",
            "2316",
            "2317",
            "2318",
            "2319",
            "2320",
            "2321",
            "2322",
            "2323",
            "2324",
            "2325",
            "2326",
            "2327",
            "2328",
            "2329",
            "2330",
            "2331",
            "2332",
            "2333",
            "2334",
            "2335",
            "2336",
            "2337",
            "2338",
            "2339",
            "2340",
            "2341",
            "2342",
            "2343",
            "2344",
            "2345",
            "2346",
            "2347",
            "2348",
            "2349",
            "2350",
            "2351",
            "2352",
            "2353",
            "2354",
            "2355",
            "2356",
            "2357",
            "2358",
            "2359",
            "2360",
            "2361",
            "2362",
            "2363",
            "2364",
            "2365",
            "2366",
            "2367",
            "2368",
            "2369",
            "2370",
            "2371",
            "2372",
            "2373",
            "2374",
            "2375",
            "2376",
            "2377",
            "2378",
            "2379",
            "2380",
            "2381",
            "2382",
            "2383",
            "2384",
            "2385",
            "2386",
            "2387",
            "2388",
            "2389",
            "2390",
            "2391",
            "2392",
            "2393",
            "2394",
            "2395",
            "2396",
            "2397",
            "2398",
            "2399",
            "2400",
            "2401",
            "2402",
            "2403",
            "2404",
            "2405",
            "2406",
            "2407",
            "2408",
            "2409",
            "2410",
            "2411",
            "2412",
            "2413",
            "2414",
            "2415",
            "2416",
            "2417",
            "2418",
            "2419",
            "2420",
            "2421",
            "2422",
            "2423",
            "2424",
            "2425",
            "2426",
            "2427",
            "2428",
            "2429",
            "2430",
            "2431",
            "2432",
            "2433",
            "2434",
            "2435",
            "2436",
            "2437",
            "2438",
            "2439",
            "2440",
            "2441",
            "2442",
            "2443",
            "2444",
            "2445",
            "2446",
            "2447",
            "2448",
            "2449",
            "2450",
            "2451",
            "2452",
            "2453",
            "2454",
            "2455",
            "2456",
            "2457",
            "2458",
            "2459",
            "2460",
            "2461",
            "2462",
            "2463",
            "2464",
            "2465",
            "2466",
            "2467",
            "2468",
            "2469",
            "2470",
            "2471",
            "2472",
            "2473",
            "2474",
            "2475",
            "2476",
            "2477",
            "2478",
            "2479",
            "2480",
            "2481",
            "2482",
            "2483",
            "2484",
            "2485",
            "2486",
            "2487",
            "2488",
            "2489",
            "2490",
            "2491",
            "2492",
            "2493",
            "2494",
            "2495",
            "2496",
            "2497",
            "2498",
            "2499",
            "2500",
            "2501",
            "2502",
            "2503",
            "2504",
            "2505",
            "2506",
            "2507",
            "2508",
            "2509",
            "2510",
            "2511",
            "2512",
            "2513",
            "2514",
            "2515",
            "2516",
            "2517",
            "2518",
            "2519",
            "2520",
            "2521",
            "2522",
            "2523",
            "2524",
            "2525",
            "2526",
            "2527",
            "2528",
            "2529",
            "2530",
            "2531",
            "2532",
            "2533",
            "2534",
            "2535",
            "2536",
            "2537",
            "2538",
            "2539",
            "2540",
            "2541",
            "2542",
            "2543",
            "2544",
            "2545",
            "2546",
            "2547",
            "2548",
            "2549",
            "2550",
            "2551",
            "2552",
            "2553",
            "2554",
            "2555",
            "2556",
            "2557",
            "2558",
            "2559",
            "2560",
            "2561",
            "2562",
            "2563",
            "2564",
            "2565",
            "2566",
            "2567",
            "2568",
            "2569",
            "2570",
            "2571",
            "2572",
            "2573",
            "2574",
            "2575",
            "2576",
            "2577",
            "2578",
            "2579",
            "2580",
            "2581",
            "2582",
            "2583",
            "2584",
            "2585",
            "2586",
            "2587",
            "2588",
            "2589",
            "2590",
            "2591",
            "2592",
            "2593",
            "2594",
            "2595",
            "2596",
            "2597",
            "2598",
            "2599",
            "2600",
            "2601",
            "2602",
            "2603",
            "2604",
            "2605",
            "2606",
            "2607",
            "2608",
            "2609",
            "2610",
            "2611",
            "2612",
            "2613",
            "2614",
            "2615",
            "2616",
            "2617",
            "2618",
            "2619",
            "2620",
            "2621",
            "2622",
            "2623",
            "2624",
            "2625",
            "2626",
            "2627",
            "2628",
            "2629",
            "2630",
            "2631",
            "2632",
            "2633",
            "2634",
            "2635",
            "2636",
            "2637",
            "2638",
            "2639",
            "2640",
            "2641",
            "2642",
            "2643",
            "2644",
            "2645",
            "2646",
            "2647",
            "2648",
            "2649",
            "2650",
            "2651",
            "2652",
            "2653",
            "2654",
            "2655",
            "2656",
            "2657",
            "2658",
            "2659",
            "2660",
            "2661",
            "2662",
            "2663",
            "2664",
            "2665",
            "2666",
            "2667",
            "2668",
            "2669",
            "2670",
            "2671",
            "2672",
            "2673",
            "2674",
            "2675",
            "2676",
            "2677",
            "2678",
            "2679",
            "2680",
            "2681",
            "2682",
            "2683",
            "2684",
            "2685",
            "2686",
            "2687",
            "2688",
            "2689",
            "2690",
            "2691",
            "2692",
            "2693",
            "2694",
            "2695",
            "2696",
            "2697",
            "2698",
            "2699",
            "2700",
            "2701",
            "2702",
            "2703",
            "2704",
            "2705",
            "2706",
            "2707",
            "2708",
            "2709",
            "2710",
            "2711",
            "2712",
            "2713",
            "2714",
            "2715",
            "2716",
            "2717",
            "2718",
            "2719",
            "2720",
            "2721",
            "2722",
            "2723",
            "2724",
            "2725",
            "2726",
            "2727",
            "2728",
            "2729",
            "2730",
            "2731",
            "2732",
            "2733",
            "2734",
            "2735",
            "2736",
            "2737",
            "2738",
            "2739",
            "2740",
            "2741",
            "2742",
            "2743",
            "2744",
            "2745",
            "2746",
            "2747",
            "2748",
            "2749",
            "2750",
            "2751",
            "2752",
            "2753",
            "2754",
            "2755",
            "2756",
            "2757",
            "2758",
            "2759",
            "2760",
            "2761",
            "2762",
            "2763",
            "2764",
            "2765",
            "2766",
            "2767",
            "2768",
            "2769",
            "2770",
            "2771",
            "2772",
            "2773",
            "2774",
            "2775",
            "2776",
            "2777",
            "2778",
            "2779",
            "2780",
            "2781",
            "2782",
            "2783",
            "2784",
            "2785",
            "2786",
            "2787",
            "2788",
            "2789",
            "2790",
            "2791",
            "2792",
            "2793",
            "2794",
            "2795",
            "2796",
            "2797",
            "2798",
            "2799",
            "2800",
            "2801",
            "2802",
            "2803",
            "2804",
            "2805",
            "2806",
            "2807",
            "2808",
            "2809",
            "2810",
            "2811",
            "2812",
            "2813",
            "2814",
            "2815",
            "2816",
            "2817",
            "2818",
            "2819",
            "2820",
            "2821",
            "2822",
            "2823",
            "2824",
            "2825",
            "2826",
            "2827",
            "2828",
            "2829",
            "2830",
            "2831",
            "2832",
            "2833",
            "2834",
            "2835",
            "2836",
            "2837",
            "2838",
            "2839",
            "2840",
            "2841",
            "2842",
            "2843",
            "2844",
            "2845",
            "2846",
            "2847",
            "2848",
            "2849",
            "2850",
            "2851",
            "2852",
            "2853",
            "2854",
            "2855",
            "2856",
            "2857",
            "2858",
            "2859",
            "2860",
            "2861",
            "2862",
            "2863",
            "2864",
            "2865",
            "2866",
            "2867",
            "2868",
            "2869",
            "2870",
            "2871",
            "2872",
            "2873",
            "2874",
            "2875",
            "2876",
            "2877",
            "2878",
            "2879",
            "2880",
            "2881",
            "2882",
            "2883",
            "2884",
            "2885",
            "2886",
            "2887",
            "2888",
            "2889",
            "2890",
            "2891",
            "2892",
            "2893",
            "2894",
            "2895",
            "2896",
            "2897",
            "2898",
            "2899",
            "2900",
            "2901",
            "2902",
            "2903",
            "2904",
            "2905",
            "2906",
            "2907",
            "2908",
            "2909",
            "2910",
            "2911",
            "2912",
            "2913",
            "2914",
            "2915",
            "2916",
            "2917",
            "2918",
            "2919",
            "2920",
            "2921",
            "2922",
            "2923",
            "2924",
            "2925",
            "2926",
            "2927",
            "2928",
            "2929",
            "2930",
            "2931",
            "2932",
            "2933",
            "2934",
            "2935",
            "2936",
            "2937",
            "2938",
            "2939",
            "2940",
            "2941",
            "2942",
            "2943",
            "2944",
            "2945",
            "2946",
            "2947",
            "2948",
            "2949",
            "2950",
            "2951",
            "2952",
            "2953",
            "2954",
            "2955",
            "2956",
            "2957",
            "2958",
            "2959",
            "2960",
            "2961",
            "2962",
            "2963",
            "2964",
            "2965",
            "2966",
            "2967",
            "2968",
            "2969",
            "2970",
            "2971",
            "2972",
            "2973",
            "2974",
            "2975",
            "2976",
            "2977",
            "2978",
            "2979",
            "2980",
            "2981",
            "2982",
            "2983",
            "2984",
            "2985",
            "2986",
            "2987",
            "2988",
            "2989",
            "2990",
            "2991",
            "2992",
            "2993",
            "2994",
            "2995",
            "2996",
            "2997",
            "2998",
            "2999",
            "3000",
            "3001",
            "3002",
            "3003",
            "3004",
            "3005",
            "3006",
            "3007",
            "3008",
            "3009",
            "3010",
            "3011",
            "3012",
            "3013"});
            this.orgarbox1.Location = new System.Drawing.Point(525, 417);
            this.orgarbox1.Name = "orgarbox1";
            this.orgarbox1.Size = new System.Drawing.Size(78, 26);
            this.orgarbox1.TabIndex = 111;
            // 
            // beneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mutualsanjoseesposomaria.Properties.Resources.descarga__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 737);
            this.Controls.Add(this.orgarbox1);
            this.Controls.Add(this.organbox2);
            this.Controls.Add(this.orgabox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.edadbton);
            this.Controls.Add(this.edadtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchnumerosocioeliminartxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numbeneficiario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eliminarnumerofacturatxt);
            this.Controls.Add(this.eliminanumerofacturabutton);
            this.Controls.Add(this.numerosocioeliminartxt);
            this.Controls.Add(this.eliminarnumerosociobutton);
            this.Controls.Add(this.actulizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sexocxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parentescoctx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fecha_ingresotxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "beneficiarios";
            this.Text = "beneficiarios";
            this.Load += new System.EventHandler(this.beneficiarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox fecha_ingresotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox parentescoctx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sexocxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button actulizar;
        private System.Windows.Forms.TextBox eliminarnumerofacturatxt;
        private System.Windows.Forms.Button eliminanumerofacturabutton;
        private System.Windows.Forms.TextBox numerosocioeliminartxt;
        private System.Windows.Forms.Button eliminarnumerosociobutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numbeneficiario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchnumerosocioeliminartxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox edadtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button edadbton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox orgarbox1;
        private System.Windows.Forms.ComboBox organbox2;
        private System.Windows.Forms.ComboBox orgabox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}