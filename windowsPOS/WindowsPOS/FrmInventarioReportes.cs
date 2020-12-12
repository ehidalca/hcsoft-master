using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCSoft.POS;
using HCSoft.POS.Negocio;
using HCSoft.POS.Objetos;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmInventarioReportes : Form
    {
        public int idproducto;
 
        public FrmInventarioReportes()
        {
            InitializeComponent();
        }

        private void btnBuscarProductoporCodigo_Click(object sender, EventArgs e)
        {

        }

        private void FrmInventarioRecepcion_Load(object sender, EventArgs e)
        {
            CargaComboTipoMovimientos();
        }


        private void CargaComboTipoMovimientos()
        {

            try
            {
                DataTable listatipomovimientos = new HCSoft.POS.TipoMovimientos().ListarTipoMovimiento();
                ObjTipoMovimiento tipomovimientodefecto = new ObjTipoMovimiento(0, "[Seleccionar]");
               
                this.ComboTipoMovimiento.DataSource = listatipomovimientos;
                this.ComboTipoMovimiento.ValueMember = "id";
                this.ComboTipoMovimiento.DisplayMember = "nombre";
                this.ComboTipoMovimiento.SelectedValue = 0;
            }
            catch (Exception)
            {

                throw;
            }


       


        }

     
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = this.dateTimePicker1.Value;
            DateTime fecha2 = this.dateTimePicker2.Value;
           

           /* List<HCSoft.POS.Objetos.ObjMovimientoBodegaReporte> movimientos = new HCSoft.POS.MovimientosBodega().ReporteMovimientos(new Formato().ObtieneFechaMysql(fecha1.Date), new Formato().ObtieneFechaMysql(fecha2.Date));

            if (movimientos.Count > 0)
            {
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = movimientos;

            }
            else
            {
                this.lblError.Text = "NO SE HAN ENCONTRADO REGISTROS";

            }*/

        }

        private void btnBuscarProductoporCodigo_Click_1(object sender, EventArgs e)
        {
           
           
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboSede_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBodegas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmDialogProveedores form = new FrmDialogProveedores();

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                int idproveedorseleccionado = form.proveedorId;
                DataTable   proveedorseleccionado= new Proveedores().TraerPorId(idproveedorseleccionado);
                //values preserved after close
               // this.txtCodigo.Text = proveedoorseleccionado.Rows[0]["codigo"].ToString();

              /*  this.txtIdProveedor.Text = proveedorseleccionado.Rows[0]["id"].ToString();
                this.txtProveedor.Text = proveedorseleccionado.Rows[0]["nombre"].ToString();*/


            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
