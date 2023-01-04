
namespace mutualsanjoseesposomaria
{
    partial class pagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.agregar = new System.Windows.Forms.Button();
            this.numerosocio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.REFRESCAR = new System.Windows.Forms.Button();
            this.numerosocioeliminartxt = new System.Windows.Forms.TextBox();
            this.eliminarnumerosociobutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tipo_p = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fechatxt = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sEGUIMIENTODEPAGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOSUNICOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOSNORMALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOSPARCIALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.ForeColor = System.Drawing.Color.Black;
            this.agregar.Location = new System.Drawing.Point(117, 287);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(202, 54);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // numerosocio
            // 
            this.numerosocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numerosocio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerosocio.ForeColor = System.Drawing.Color.Gray;
            this.numerosocio.Location = new System.Drawing.Point(162, 88);
            this.numerosocio.Name = "numerosocio";
            this.numerosocio.Size = new System.Drawing.Size(157, 29);
            this.numerosocio.TabIndex = 2;
            this.numerosocio.Text = "NUMERO SOCIO";
            this.numerosocio.Enter += new System.EventHandler(this.numerosocio_Enter);
            this.numerosocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerosocio_KeyPress);
            this.numerosocio.Leave += new System.EventHandler(this.numerosocio_Leave);
            this.numerosocio.Validating += new System.ComponentModel.CancelEventHandler(this.numerosocio_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.REFRESCAR);
            this.panel1.Controls.Add(this.numerosocioeliminartxt);
            this.panel1.Controls.Add(this.eliminarnumerosociobutton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tipo_p);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.fechatxt);
            this.panel1.Controls.Add(this.cantidad);
            this.panel1.Controls.Add(this.agregar);
            this.panel1.Controls.Add(this.numerosocio);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 514);
            this.panel1.TabIndex = 7;
            // 
            // REFRESCAR
            // 
            this.REFRESCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.REFRESCAR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REFRESCAR.ForeColor = System.Drawing.SystemColors.MenuText;
            this.REFRESCAR.Image = global::mutualsanjoseesposomaria.Properties.Resources.descarga__2_;
            this.REFRESCAR.Location = new System.Drawing.Point(392, 227);
            this.REFRESCAR.Name = "REFRESCAR";
            this.REFRESCAR.Size = new System.Drawing.Size(124, 95);
            this.REFRESCAR.TabIndex = 46;
            this.REFRESCAR.Text = "ACTULIZAR  Ó REFRESCA\r\nTABLA";
            this.REFRESCAR.UseVisualStyleBackColor = true;
            this.REFRESCAR.Click += new System.EventHandler(this.REFRESCAR_Click);
            // 
            // numerosocioeliminartxt
            // 
            this.numerosocioeliminartxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerosocioeliminartxt.ForeColor = System.Drawing.Color.DarkGray;
            this.numerosocioeliminartxt.Location = new System.Drawing.Point(513, 131);
            this.numerosocioeliminartxt.Name = "numerosocioeliminartxt";
            this.numerosocioeliminartxt.Size = new System.Drawing.Size(219, 26);
            this.numerosocioeliminartxt.TabIndex = 45;
            this.numerosocioeliminartxt.Text = "NUMERO  DEL SOCIO";
            this.numerosocioeliminartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numerosocioeliminartxt.Enter += new System.EventHandler(this.numerosocioeliminartxt_Enter);
            this.numerosocioeliminartxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerosocioeliminartxt_KeyPress);
            this.numerosocioeliminartxt.Leave += new System.EventHandler(this.numerosocioeliminartxt_Leave);
            this.numerosocioeliminartxt.Validating += new System.ComponentModel.CancelEventHandler(this.numerosocioeliminartxt_Validating);
            // 
            // eliminarnumerosociobutton
            // 
            this.eliminarnumerosociobutton.BackColor = System.Drawing.Color.Brown;
            this.eliminarnumerosociobutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarnumerosociobutton.Location = new System.Drawing.Point(392, 89);
            this.eliminarnumerosociobutton.Name = "eliminarnumerosociobutton";
            this.eliminarnumerosociobutton.Size = new System.Drawing.Size(115, 68);
            this.eliminarnumerosociobutton.TabIndex = 44;
            this.eliminarnumerosociobutton.Text = "ELIMINAR PAGOS INSCRIPCION";
            this.eliminarnumerosociobutton.UseVisualStyleBackColor = false;
            this.eliminarnumerosociobutton.Click += new System.EventHandler(this.eliminarnumerosociobutton_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 347);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.Size = new System.Drawing.Size(758, 167);
            this.dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "tipo de pago";
            // 
            // tipo_p
            // 
            this.tipo_p.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_p.FormattingEnabled = true;
            this.tipo_p.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.tipo_p.Location = new System.Drawing.Point(162, 135);
            this.tipo_p.Name = "tipo_p";
            this.tipo_p.Size = new System.Drawing.Size(72, 30);
            this.tipo_p.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chartreuse;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 41);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "INSCRICIONES";
            // 
            // fechatxt
            // 
            this.fechatxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechatxt.Enabled = false;
            this.fechatxt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechatxt.ForeColor = System.Drawing.Color.Gray;
            this.fechatxt.Location = new System.Drawing.Point(162, 178);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.Size = new System.Drawing.Size(206, 29);
            this.fechatxt.TabIndex = 13;
            this.fechatxt.Text = "FECHA AUTOMATICA";
            // 
            // cantidad
            // 
            this.cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cantidad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.ForeColor = System.Drawing.Color.Gray;
            this.cantidad.Location = new System.Drawing.Point(162, 227);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(127, 29);
            this.cantidad.TabIndex = 12;
            this.cantidad.Text = "CANTIDAD";
            this.cantidad.Enter += new System.EventHandler(this.cantidad_Enter);
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_KeyPress);
            this.cantidad.Leave += new System.EventHandler(this.cantidad_Leave);
            this.cantidad.Validating += new System.ComponentModel.CancelEventHandler(this.cantidad_Validating);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEGUIMIENTODEPAGOSToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 25);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sEGUIMIENTODEPAGOSToolStripMenuItem
            // 
            this.sEGUIMIENTODEPAGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pAGOSUNICOSToolStripMenuItem,
            this.pAGOSNORMALESToolStripMenuItem,
            this.pAGOSPARCIALESToolStripMenuItem});
            this.sEGUIMIENTODEPAGOSToolStripMenuItem.Name = "sEGUIMIENTODEPAGOSToolStripMenuItem";
            this.sEGUIMIENTODEPAGOSToolStripMenuItem.Size = new System.Drawing.Size(167, 21);
            this.sEGUIMIENTODEPAGOSToolStripMenuItem.Text = "SEGUIMIENTO DE PAGOS";
            // 
            // pAGOSUNICOSToolStripMenuItem
            // 
            this.pAGOSUNICOSToolStripMenuItem.Name = "pAGOSUNICOSToolStripMenuItem";
            this.pAGOSUNICOSToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pAGOSUNICOSToolStripMenuItem.Text = "PAGOS UNICOS ";
            this.pAGOSUNICOSToolStripMenuItem.Click += new System.EventHandler(this.pAGOSUNICOSToolStripMenuItem_Click);
            // 
            // pAGOSNORMALESToolStripMenuItem
            // 
            this.pAGOSNORMALESToolStripMenuItem.Name = "pAGOSNORMALESToolStripMenuItem";
            this.pAGOSNORMALESToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pAGOSNORMALESToolStripMenuItem.Text = "PAGOS NORMALES";
            this.pAGOSNORMALESToolStripMenuItem.Click += new System.EventHandler(this.pAGOSNORMALESToolStripMenuItem_Click);
            // 
            // pAGOSPARCIALESToolStripMenuItem
            // 
            this.pAGOSPARCIALESToolStripMenuItem.Name = "pAGOSPARCIALESToolStripMenuItem";
            this.pAGOSPARCIALESToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pAGOSPARCIALESToolStripMenuItem.Text = "PAGOS PARCIALES";
            this.pAGOSPARCIALESToolStripMenuItem.Click += new System.EventHandler(this.pAGOSPARCIALESToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 514);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pagos";
            this.Text = "pagos";
            this.Load += new System.EventHandler(this.pagos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox numerosocio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.TextBox fechatxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sEGUIMIENTODEPAGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAGOSUNICOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAGOSNORMALESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAGOSPARCIALESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox tipo_p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox numerosocioeliminartxt;
        private System.Windows.Forms.Button eliminarnumerosociobutton;
        private System.Windows.Forms.Button REFRESCAR;
    }
}