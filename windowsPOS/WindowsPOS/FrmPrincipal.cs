using System;
using System.Data;
using System.Windows.Forms;
using HCSoft.POS;
using WindowsPOS;

namespace HCSoft.POS.WinApp
{
    public partial class FrmPrincipal : Form
    {
        public int usuarioId { get; set;}

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            DataTable dt = new Usuarios().Listar();
            
            FrmLogin frmLogin = new FrmLogin();
            var result = frmLogin.ShowDialog();
            this.Visible = false;
            if (result == DialogResult.OK)
            {
                
                CargaDatosUsuario(frmLogin.usuarioId);

            }       
            
        }

        private void CargaDatosUsuario(int usuarioId)
        {
            try
            {
                DataTable dt = new Usuarios().Consultar(usuarioId);
                if (dt.Rows.Count > 0)
                {
                    this.lblNombreUsuario.Text = dt.Rows[0]["nombre"].ToString();    
                    Global.usuarioId = Int32.Parse(dt.Rows[0]["id"].ToString());
                }
               
            }
            catch (Exception)
            {

                throw;
            }
 

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.pnlControl.Controls.Count > 0)
                this.pnlControl.Controls.RemoveAt(0);
            FrmProductos hijo1 = new FrmProductos();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlControl.Controls.Add(hijo1);
            this.pnlControl.Tag = hijo1;
            hijo1.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlControl_Paint(object sender, PaintEventArgs e)
        {
           
        }

       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (this.pnlControl.Controls.Count > 0)
                this.pnlControl.Controls.RemoveAt(0);
            FrmMantenedorProductos hijo1 = new FrmMantenedorProductos();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlControl.Controls.Add(hijo1);
            this.pnlControl.Tag = hijo1;
            hijo1.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

            if (this.pnlControl.Controls.Count > 0)
                this.pnlControl.Controls.RemoveAt(0);
            FrmPedidos hijo1 = new FrmPedidos();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlControl.Controls.Add(hijo1);
            this.pnlControl.Tag = hijo1;
            hijo1.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (this.pnlControl.Controls.Count > 0)
                this.pnlControl.Controls.RemoveAt(0);
            FrmConfiguracion hijo1 = new FrmConfiguracion();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlControl.Controls.Add(hijo1);
            this.pnlControl.Tag = hijo1;
            hijo1.Show();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {

            if (this.pnlControl.Controls.Count > 0)
                this.pnlControl.Controls.RemoveAt(0);
            FrmCaja hijo1 = new FrmCaja();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlControl.Controls.Add(hijo1);
            this.pnlControl.Tag = hijo1;
            hijo1.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

            if (this.pnlControl.Controls.Count > 0)
                this.pnlControl.Controls.RemoveAt(0);
            FrmInventario hijo1 = new FrmInventario();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlControl.Controls.Add(hijo1);
            this.pnlControl.Tag = hijo1;
            hijo1.Show();


        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (this.pnlControl.Controls.Count > 0)
                this.pnlControl.Controls.RemoveAt(0);
            FrmVentas hijo1 = new FrmVentas();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlControl.Controls.Add(hijo1);
            this.pnlControl.Tag = hijo1;
            hijo1.Show();

        }
    }
}
