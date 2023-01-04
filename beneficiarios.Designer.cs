
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
            this.edadtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchnumerosocioeliminartxt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.agregar.Location = new System.Drawing.Point(418, 260);
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
            this.panel1.Size = new System.Drawing.Size(909, 38);
            this.panel1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(312, 9);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 540);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(909, 173);
            this.dataGridView1.TabIndex = 31;
            // 
            // actulizar
            // 
            this.actulizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actulizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actulizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actulizar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.actulizar.Image = global::mutualsanjoseesposomaria.Properties.Resources.descarga__2_;
            this.actulizar.Location = new System.Drawing.Point(439, 378);
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
            this.eliminarnumerofacturatxt.Location = new System.Drawing.Point(672, 297);
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
            this.eliminanumerofacturabutton.Location = new System.Drawing.Point(534, 246);
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
            this.numerosocioeliminartxt.Location = new System.Drawing.Point(664, 178);
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
            this.eliminarnumerosociobutton.Location = new System.Drawing.Point(530, 117);
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
            this.label8.Location = new System.Drawing.Point(13, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 22);
            this.label8.TabIndex = 93;
            this.label8.Text = "EDAD";
            // 
            // edadtxt
            // 
            this.edadtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edadtxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadtxt.Location = new System.Drawing.Point(226, 413);
            this.edadtxt.Name = "edadtxt";
            this.edadtxt.Size = new System.Drawing.Size(111, 26);
            this.edadtxt.TabIndex = 94;
            this.edadtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edadtxt_KeyPress);
            this.edadtxt.Validating += new System.ComponentModel.CancelEventHandler(this.edadtxt_Validating);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::mutualsanjoseesposomaria.Properties.Resources.buscar;
            this.button1.Location = new System.Drawing.Point(785, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 108);
            this.button1.TabIndex = 96;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchnumerosocioeliminartxt
            // 
            this.searchnumerosocioeliminartxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchnumerosocioeliminartxt.ForeColor = System.Drawing.Color.DarkGray;
            this.searchnumerosocioeliminartxt.Location = new System.Drawing.Point(560, 508);
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
            // beneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mutualsanjoseesposomaria.Properties.Resources.descarga__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 713);
            this.Controls.Add(this.searchnumerosocioeliminartxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edadtxt);
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
        private System.Windows.Forms.TextBox edadtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchnumerosocioeliminartxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}