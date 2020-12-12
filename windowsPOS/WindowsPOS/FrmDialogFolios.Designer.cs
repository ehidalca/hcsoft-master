namespace HCSoft.POS.WinApp
{
    partial class FrmDialogFolios
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
            this.label9 = new System.Windows.Forms.Label();
            this.tbnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolioInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFolioTermino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolioSiguiente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCajas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(26, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Folios";
            // 
            // tbnGuardar
            // 
            this.tbnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.tbnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.tbnGuardar.Image = global::WindowsPOS.Properties.Resources.disk_save_yellow_icon;
            this.tbnGuardar.Location = new System.Drawing.Point(291, 439);
            this.tbnGuardar.Name = "tbnGuardar";
            this.tbnGuardar.Size = new System.Drawing.Size(59, 62);
            this.tbnGuardar.TabIndex = 41;
            this.tbnGuardar.UseVisualStyleBackColor = false;
            this.tbnGuardar.Click += new System.EventHandler(this.tbnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Caja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tipo Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Folio Inicial:";
            // 
            // txtFolioInicial
            // 
            this.txtFolioInicial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFolioInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioInicial.Location = new System.Drawing.Point(27, 163);
            this.txtFolioInicial.Name = "txtFolioInicial";
            this.txtFolioInicial.Size = new System.Drawing.Size(259, 26);
            this.txtFolioInicial.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Folio Termino:";
            // 
            // txtFolioTermino
            // 
            this.txtFolioTermino.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFolioTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioTermino.Location = new System.Drawing.Point(27, 228);
            this.txtFolioTermino.Name = "txtFolioTermino";
            this.txtFolioTermino.Size = new System.Drawing.Size(259, 26);
            this.txtFolioTermino.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Folio Siguiente:";
            // 
            // txtFolioSiguiente
            // 
            this.txtFolioSiguiente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFolioSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioSiguiente.Location = new System.Drawing.Point(27, 289);
            this.txtFolioSiguiente.Name = "txtFolioSiguiente";
            this.txtFolioSiguiente.Size = new System.Drawing.Size(259, 26);
            this.txtFolioSiguiente.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCajas);
            this.groupBox1.Controls.Add(this.txtFolioSiguiente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFolioTermino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFolioInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTipoDocumento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 341);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(27, 99);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(259, 28);
            this.cmbTipoDocumento.TabIndex = 44;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(54, 397);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(42, 20);
            this.lblError.TabIndex = 47;
            this.lblError.Text = "error";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbCajas
            // 
            this.cmbCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCajas.FormattingEnabled = true;
            this.cmbCajas.Location = new System.Drawing.Point(27, 39);
            this.cmbCajas.Name = "cmbCajas";
            this.cmbCajas.Size = new System.Drawing.Size(259, 28);
            this.cmbCajas.TabIndex = 52;
            // 
            // FrmDialogFolios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 513);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbnGuardar);
            this.Controls.Add(this.label9);
            this.Name = "FrmDialogFolios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDialogFolios";
            this.Load += new System.EventHandler(this.FrmDialogFolios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button tbnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolioInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolioTermino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolioSiguiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbCajas;
    }
}