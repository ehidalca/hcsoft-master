using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCSoft.POS.WinApp
{
    public partial class FrmConfiguracion : Form
    {
        public int usuarioId;

        public FrmConfiguracion()
        {
            InitializeComponent();
        }

      
        private void btnCajas_Click(object sender, EventArgs e)
        {
            if (this.pnlFormulario.Controls.Count > 0)
                this.pnlFormulario.Controls.RemoveAt(0);
            FrmMantenedorCajas hijo1 = new FrmMantenedorCajas();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlFormulario.Controls.Add(hijo1);
            this.pnlFormulario.Tag = hijo1;
            hijo1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

      

       

        private void btnfolios_Click(object sender, EventArgs e)
        {
            
        }

        private void cajasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pnlFormulario.Controls.Count > 0)
                this.pnlFormulario.Controls.RemoveAt(0);
            FrmMantenedorCategorias hijo1 = new FrmMantenedorCategorias();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlFormulario.Controls.Add(hijo1);
            this.pnlFormulario.Tag = hijo1;
            hijo1.Show();
        
    }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void foliosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.pnlFormulario.Controls.Count > 0)
                this.pnlFormulario.Controls.RemoveAt(0);
            FrmFolios hijo1 = new FrmFolios();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlFormulario.Controls.Add(hijo1);
            this.pnlFormulario.Tag = hijo1;
            hijo1.Show();
        }

        private void pnlFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (this.pnlFormulario.Controls.Count > 0)
                this.pnlFormulario.Controls.RemoveAt(0);
            FrmConfiguracionCaja hijo1 = new FrmConfiguracionCaja();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlFormulario.Controls.Add(hijo1);
            this.pnlFormulario.Tag = hijo1;
            hijo1.Show();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            FrmMantenedorCajas frmcajas = new FrmMantenedorCajas();
            frmcajas.ShowDialog();
        
        }

        private void btnCajas_Click_1(object sender, EventArgs e)
        {
            FrmMantenedorCajas  frmcajas = new FrmMantenedorCajas();
            frmcajas.Show();
        }

        private void btnFolios_Click_1(object sender, EventArgs e)
        {
            FrmFolios FrmFolios = new FrmFolios();
            FrmFolios.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmMantenedorCategorias frmCategorias = new FrmMantenedorCategorias();
            frmCategorias.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmMantenedorProductos frmProductos = new FrmMantenedorProductos();
            frmProductos.Show();

        }

        private void btnUnidadesMedida_Click(object sender, EventArgs e)
        {
            frmMantenedorUnidadMedida frmUnidades = new frmMantenedorUnidadMedida();
            frmUnidades.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmMantenedorUsuarios frmUsuarios = new FrmMantenedorUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            FrmMantenedorSucursales frmSucursales = new FrmMantenedorSucursales();
            frmSucursales.ShowDialog();
        }
    }
}
