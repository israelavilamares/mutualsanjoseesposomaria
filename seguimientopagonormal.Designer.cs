
namespace mutualsanjoseesposomaria
{
    partial class seguimientopagonormal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nombrequinfacturatxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.eliminarnumerofacturatxt = new System.Windows.Forms.TextBox();
            this.eliminanumerofactura = new System.Windows.Forms.Button();
            this.numerosocioeliminartxt = new System.Windows.Forms.TextBox();
            this.eliminarnumerosocio = new System.Windows.Forms.Button();
            this.numerodefacturatxt = new System.Windows.Forms.TextBox();
            this.miperimerpago = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechatxt = new System.Windows.Forms.TextBox();
            this.importe = new System.Windows.Forms.TextBox();
            this.mes1 = new System.Windows.Forms.TextBox();
            this.mes2 = new System.Windows.Forms.TextBox();
            this.idpagonormal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.observacionestxt = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.observacionestxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nombrequinfacturatxt);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.eliminarnumerofacturatxt);
            this.panel1.Controls.Add(this.eliminanumerofactura);
            this.panel1.Controls.Add(this.numerosocioeliminartxt);
            this.panel1.Controls.Add(this.eliminarnumerosocio);
            this.panel1.Controls.Add(this.numerodefacturatxt);
            this.panel1.Controls.Add(this.miperimerpago);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fechatxt);
            this.panel1.Controls.Add(this.importe);
            this.panel1.Controls.Add(this.mes1);
            this.panel1.Controls.Add(this.mes2);
            this.panel1.Controls.Add(this.idpagonormal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 590);
            this.panel1.TabIndex = 0;
            // 
            // nombrequinfacturatxt
            // 
            this.nombrequinfacturatxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombrequinfacturatxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrequinfacturatxt.ForeColor = System.Drawing.Color.Gray;
            this.nombrequinfacturatxt.Location = new System.Drawing.Point(460, 284);
            this.nombrequinfacturatxt.Name = "nombrequinfacturatxt";
            this.nombrequinfacturatxt.Size = new System.Drawing.Size(224, 26);
            this.nombrequinfacturatxt.TabIndex = 81;
            this.nombrequinfacturatxt.Text = "NOMBRE QUIEN FACTURA";
            this.nombrequinfacturatxt.Enter += new System.EventHandler(this.nombrequinfacturatxt_Enter);
            this.nombrequinfacturatxt.Leave += new System.EventHandler(this.nombrequinfacturatxt_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(1174, 29);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Image = global::mutualsanjoseesposomaria.Properties.Resources.descarga__2_;
            this.button1.Location = new System.Drawing.Point(2, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 96);
            this.button1.TabIndex = 36;
            this.button1.Text = "ACTULIZAR TABLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminarnumerofacturatxt
            // 
            this.eliminarnumerofacturatxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarnumerofacturatxt.ForeColor = System.Drawing.Color.DarkGray;
            this.eliminarnumerofacturatxt.Location = new System.Drawing.Point(668, 187);
            this.eliminarnumerofacturatxt.Name = "eliminarnumerofacturatxt";
            this.eliminarnumerofacturatxt.Size = new System.Drawing.Size(160, 26);
            this.eliminarnumerofacturatxt.TabIndex = 14;
            this.eliminarnumerofacturatxt.Text = "NUMERO FACTURA";
            this.eliminarnumerofacturatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eliminarnumerofacturatxt.Enter += new System.EventHandler(this.eliminarnumerofacturatxt_Enter);
            this.eliminarnumerofacturatxt.Leave += new System.EventHandler(this.eliminarnumerofacturatxt_Leave);
            // 
            // eliminanumerofactura
            // 
            this.eliminanumerofactura.BackColor = System.Drawing.Color.Brown;
            this.eliminanumerofactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminanumerofactura.Location = new System.Drawing.Point(566, 145);
            this.eliminanumerofactura.Name = "eliminanumerofactura";
            this.eliminanumerofactura.Size = new System.Drawing.Size(96, 68);
            this.eliminanumerofactura.TabIndex = 13;
            this.eliminanumerofactura.Text = "ELIMINAR SOLO UN PAGO";
            this.eliminanumerofactura.UseVisualStyleBackColor = false;
            this.eliminanumerofactura.Click += new System.EventHandler(this.eliminanumerofactura_Click);
            // 
            // numerosocioeliminartxt
            // 
            this.numerosocioeliminartxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerosocioeliminartxt.ForeColor = System.Drawing.Color.DarkGray;
            this.numerosocioeliminartxt.Location = new System.Drawing.Point(668, 84);
            this.numerosocioeliminartxt.Name = "numerosocioeliminartxt";
            this.numerosocioeliminartxt.Size = new System.Drawing.Size(219, 26);
            this.numerosocioeliminartxt.TabIndex = 12;
            this.numerosocioeliminartxt.Text = "NUMERO PAGO DEL SOCIO";
            this.numerosocioeliminartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numerosocioeliminartxt.Enter += new System.EventHandler(this.numerosocioeliminartxt_Enter);
            this.numerosocioeliminartxt.Leave += new System.EventHandler(this.numerosocioeliminartxt_Leave);
            // 
            // eliminarnumerosocio
            // 
            this.eliminarnumerosocio.BackColor = System.Drawing.Color.Brown;
            this.eliminarnumerosocio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarnumerosocio.Location = new System.Drawing.Point(566, 42);
            this.eliminarnumerosocio.Name = "eliminarnumerosocio";
            this.eliminarnumerosocio.Size = new System.Drawing.Size(96, 68);
            this.eliminarnumerosocio.TabIndex = 11;
            this.eliminarnumerosocio.Text = "ELIMINAR TODOS PAGOS ";
            this.eliminarnumerosocio.UseVisualStyleBackColor = false;
            this.eliminarnumerosocio.Click += new System.EventHandler(this.eliminarnumerosocio_Click);
            // 
            // numerodefacturatxt
            // 
            this.numerodefacturatxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerodefacturatxt.ForeColor = System.Drawing.Color.DarkGray;
            this.numerodefacturatxt.Location = new System.Drawing.Point(162, 49);
            this.numerodefacturatxt.Name = "numerodefacturatxt";
            this.numerodefacturatxt.Size = new System.Drawing.Size(166, 26);
            this.numerodefacturatxt.TabIndex = 10;
            this.numerodefacturatxt.Text = "NUMERO FACTURA";
            this.numerodefacturatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numerodefacturatxt.Enter += new System.EventHandler(this.numerodefacturatxt_Enter);
            this.numerodefacturatxt.Leave += new System.EventHandler(this.numerodefacturatxt_Leave);
            // 
            // miperimerpago
            // 
            this.miperimerpago.BackColor = System.Drawing.Color.Brown;
            this.miperimerpago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miperimerpago.Location = new System.Drawing.Point(278, 298);
            this.miperimerpago.Name = "miperimerpago";
            this.miperimerpago.Size = new System.Drawing.Size(96, 69);
            this.miperimerpago.TabIndex = 9;
            this.miperimerpago.Text = "PAGAR";
            this.miperimerpago.UseVisualStyleBackColor = false;
            this.miperimerpago.Click += new System.EventHandler(this.miperimerpago_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "ÁL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "PAGADO DEL MES";
            // 
            // fechatxt
            // 
            this.fechatxt.Enabled = false;
            this.fechatxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechatxt.ForeColor = System.Drawing.Color.DarkGray;
            this.fechatxt.Location = new System.Drawing.Point(162, 139);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.Size = new System.Drawing.Size(298, 26);
            this.fechatxt.TabIndex = 5;
            this.fechatxt.Text = "FECHA AUTOMATICA";
            // 
            // importe
            // 
            this.importe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importe.ForeColor = System.Drawing.Color.Gray;
            this.importe.Location = new System.Drawing.Point(256, 240);
            this.importe.Name = "importe";
            this.importe.Size = new System.Drawing.Size(130, 26);
            this.importe.TabIndex = 4;
            this.importe.Text = "IMPORTE";
            this.importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.importe.Enter += new System.EventHandler(this.importe_Enter);
            this.importe.Leave += new System.EventHandler(this.importe_Leave);
            // 
            // mes1
            // 
            this.mes1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mes1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes1.ForeColor = System.Drawing.Color.DarkGray;
            this.mes1.Location = new System.Drawing.Point(162, 183);
            this.mes1.Name = "mes1";
            this.mes1.Size = new System.Drawing.Size(140, 26);
            this.mes1.TabIndex = 3;
            this.mes1.Text = "EJE. MAYO 22";
            this.mes1.Enter += new System.EventHandler(this.mes1_Enter);
            this.mes1.Leave += new System.EventHandler(this.mes1_Leave);
            // 
            // mes2
            // 
            this.mes2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mes2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes2.ForeColor = System.Drawing.Color.DarkGray;
            this.mes2.Location = new System.Drawing.Point(353, 183);
            this.mes2.Name = "mes2";
            this.mes2.Size = new System.Drawing.Size(150, 26);
            this.mes2.TabIndex = 1;
            this.mes2.Text = "EJEM. ENERO 23";
            this.mes2.Enter += new System.EventHandler(this.mes2_Enter);
            this.mes2.Leave += new System.EventHandler(this.mes2_Leave);
            // 
            // idpagonormal
            // 
            this.idpagonormal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpagonormal.ForeColor = System.Drawing.Color.DarkGray;
            this.idpagonormal.Location = new System.Drawing.Point(162, 91);
            this.idpagonormal.Name = "idpagonormal";
            this.idpagonormal.Size = new System.Drawing.Size(224, 26);
            this.idpagonormal.TabIndex = 0;
            this.idpagonormal.Text = "NUMERO PAGO DEL SOCIO";
            this.idpagonormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idpagonormal.Enter += new System.EventHandler(this.idpagonormal_Enter);
            this.idpagonormal.Leave += new System.EventHandler(this.idpagonormal_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 198);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(956, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 82;
            this.label3.Text = "OBSERVACIONES";
            // 
            // observacionestxt
            // 
            this.observacionestxt.Location = new System.Drawing.Point(895, 164);
            this.observacionestxt.Name = "observacionestxt";
            this.observacionestxt.Size = new System.Drawing.Size(267, 169);
            this.observacionestxt.TabIndex = 83;
            this.observacionestxt.Text = "";
            // 
            // seguimientopagonormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "seguimientopagonormal";
            this.Text = "seguimientopagonormal";
            this.Load += new System.EventHandler(this.seguimientopagonormal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fechatxt;
        private System.Windows.Forms.TextBox importe;
        private System.Windows.Forms.TextBox mes1;
        private System.Windows.Forms.TextBox mes2;
        private System.Windows.Forms.TextBox idpagonormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button miperimerpago;
        private System.Windows.Forms.TextBox numerodefacturatxt;
        private System.Windows.Forms.TextBox eliminarnumerofacturatxt;
        private System.Windows.Forms.Button eliminanumerofactura;
        private System.Windows.Forms.TextBox numerosocioeliminartxt;
        private System.Windows.Forms.Button eliminarnumerosocio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox nombrequinfacturatxt;
        private System.Windows.Forms.RichTextBox observacionestxt;
        private System.Windows.Forms.Label label3;
    }
}