using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCSoft.POS.Negocio;
using HCSoft.POS.Objetos;

namespace HCSoft.POS.WinApp
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnBuscarProductoporCodigo_Click(object sender, EventArgs e)
        {

        }

        public void Buscar()
        {


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {



        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recepcionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pnlInventario.Controls.Count > 0)
                this.pnlInventario.Controls.RemoveAt(0);
            FrmInventarioRecepcion hijo1 = new FrmInventarioRecepcion();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlInventario.Controls.Add(hijo1);
            this.pnlInventario.Tag = hijo1;
            hijo1.Show();
        }

        private void moverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pnlInventario.Controls.Count > 0)
                this.pnlInventario.Controls.RemoveAt(0);
            FrmInventarioTraspaso hijo1 = new FrmInventarioTraspaso();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlInventario.Controls.Add(hijo1);
            this.pnlInventario.Tag = hijo1;
            hijo1.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pnlInventario.Controls.Count > 0)
                this.pnlInventario.Controls.RemoveAt(0);
            FrmInventarioReportes hijo1 = new FrmInventarioReportes();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.pnlInventario.Controls.Add(hijo1);
            this.pnlInventario.Tag = hijo1;
            hijo1.Show();
        }

        private void btnRecepcionar_Click(object sender, EventArgs e)
        {

            FrmInventarioRecepcion hijo1 = new FrmInventarioRecepcion();
           
            hijo1.ShowDialog();

        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            FrmReporteMovimientoProductos form = new FrmReporteMovimientoProductos();
            form.ShowDialog();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInventarioTraspaso frmTraspasos = new FrmInventarioTraspaso();
            frmTraspasos.ShowDialog();
        }
    }
    
}
