namespace HCSoft.POS.WinApp
{
    partial class FrmInventario
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlInventario = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecepcionar = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlInventario
            // 
            this.pnlInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInventario.Controls.Add(this.btnMovimientos);
            this.pnlInventario.Controls.Add(this.label3);
            this.pnlInventario.Controls.Add(this.button3);
            this.pnlInventario.Controls.Add(this.btnRecepcionar);
            this.pnlInventario.Controls.Add(this.button2);
            this.pnlInventario.Controls.Add(this.label2);
            this.pnlInventario.Location = new System.Drawing.Point(12, 37);
            this.pnlInventario.Name = "pnlInventario";
            this.pnlInventario.Size = new System.Drawing.Size(1038, 669);
            this.pnlInventario.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(230, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 90);
            this.button3.TabIndex = 17;
            this.button3.Text = "Devolver";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(130, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 90);
            this.button2.TabIndex = 16;
            this.button2.Text = "Mover";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMovimientos.FlatAppearance.BorderSize = 0;
            this.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.ForeColor = System.Drawing.Color.White;
            this.btnMovimientos.Location = new System.Drawing.Point(30, 233);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(94, 90);
            this.btnMovimientos.TabIndex = 15;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.UseVisualStyleBackColor = false;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Reportes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Productos:";
            // 
            // btnRecepcionar
            // 
            this.btnRecepcionar.BackColor = System.Drawing.Color.LightBlue;
            this.btnRecepcionar.FlatAppearance.BorderSize = 0;
            this.btnRecepcionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepcionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepcionar.Location = new System.Drawing.Point(30, 57);
            this.btnRecepcionar.Name = "btnRecepcionar";
            this.btnRecepcionar.Size = new System.Drawing.Size(94, 90);
            this.btnRecepcionar.TabIndex = 4;
            this.btnRecepcionar.Text = "Recepción";
            this.btnRecepcionar.UseVisualStyleBackColor = false;
            this.btnRecepcionar.Click += new System.EventHandler(this.btnRecepcionar_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(944, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inventario";
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 721);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlInventario);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.pnlInventario.ResumeLayout(false);
            this.pnlInventario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlInventario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecepcionar;
    }
}