namespace HCSoft.POS.WinApp
{
    partial class FrmDialogPago
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
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Creditodebito = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMedioPago = new System.Windows.Forms.Panel();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.pnlMedioPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(27, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Pago ";
            // 
            // btn_Creditodebito
            // 
            this.btn_Creditodebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Creditodebito.Image = global::WindowsPOS.Properties.Resources.tarjeta_de_credito;
            this.btn_Creditodebito.Location = new System.Drawing.Point(32, 155);
            this.btn_Creditodebito.Name = "btn_Creditodebito";
            this.btn_Creditodebito.Size = new System.Drawing.Size(107, 69);
            this.btn_Creditodebito.TabIndex = 42;
            this.btn_Creditodebito.UseVisualStyleBackColor = true;
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfectivo.Image = global::WindowsPOS.Properties.Resources.efectivo;
            this.btnEfectivo.Location = new System.Drawing.Point(32, 70);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(107, 69);
            this.btnEfectivo.TabIndex = 41;
            this.btnEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(509, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 39);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "label1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsPOS.Properties.Resources.pagar;
            this.button1.Location = new System.Drawing.Point(723, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 69);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlMedioPago
            // 
            this.pnlMedioPago.Controls.Add(this.txtEfectivo);
            this.pnlMedioPago.Location = new System.Drawing.Point(155, 70);
            this.pnlMedioPago.Name = "pnlMedioPago";
            this.pnlMedioPago.Size = new System.Drawing.Size(675, 326);
            this.pnlMedioPago.TabIndex = 45;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.Location = new System.Drawing.Point(18, 16);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(164, 31);
            this.txtEfectivo.TabIndex = 0;
            // 
            // FrmDialogPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 497);
            this.Controls.Add(this.pnlMedioPago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btn_Creditodebito);
            this.Controls.Add(this.btnEfectivo);
            this.Controls.Add(this.label9);
            this.Name = "FrmDialogPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDialogPago";
            this.Load += new System.EventHandler(this.FrmDialogPago_Load);
            this.pnlMedioPago.ResumeLayout(false);
            this.pnlMedioPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btn_Creditodebito;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMedioPago;
        private System.Windows.Forms.TextBox txtEfectivo;
    }
}