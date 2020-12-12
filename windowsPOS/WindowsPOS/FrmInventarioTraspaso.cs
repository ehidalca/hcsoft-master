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
    public partial class FrmInventarioTraspaso : Form
    {
        public int idproducto;
 
        public FrmInventarioTraspaso()
        {
            InitializeComponent();
        }

        private void btnBuscarProductoporCodigo_Click(object sender, EventArgs e)
        {

        }

        private void FrmInventarioRecepcion_Load(object sender, EventArgs e)
        {
            try
            {
                        CargarComboSedesOrigen();
                       //CargarBodegasOrigen();
                        CargarComboSedesDestino();
                       // CargarBodegasDestino();
            }
            catch (Exception)
            {

                throw;
            }
            
          
        }


        private void CargarBodegasOrigen()
        {
            try
            {
                var sedeOrigen = (HCSoft.Util.Item)this.cmbSedeOrigen.SelectedItem;
                DataTable dtBodegasOrigen = new DataTable();
                if (sedeOrigen.Value != "-" && sedeOrigen.Value != "")
                {
                    dtBodegasOrigen = new HCSoft.POS.Bodegas().ListarPorSucursal(Int32.Parse(sedeOrigen.Value));
                }
               // new HCSoft.UI().CargarCombo(dtBodegasOrigen, this.cmbBodegasOrigen);
               
            }
            catch (Exception e)
            {

                MessageBox.Show("Se ha provocado un error al  intentar cagar el combo de bodegas", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        private void CargarBodegasDestino()
        {
            try
            {
                var sedeDestino = (HCSoft.Util.Item)this.cmbSucursalDestino.SelectedItem;
                DataTable dtBodegasDestino = new DataTable();
                if (sedeDestino.Value != "-" && sedeDestino.Value != "")
                {
                    dtBodegasDestino = new HCSoft.POS.Bodegas().ListarPorSucursal(Int32.Parse(sedeDestino.Value));
                }
                new UI().CargarCombo(dtBodegasDestino, this.cmbBodegaDestino);

            }
            catch (Exception e)
            {

                MessageBox.Show("Se ha provocado un error al  intentar cagar el combo de bodegas destino", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        private void CargarComboSedesOrigen()
        {
            try
            {
               DataTable dtSucursales  = new HCSoft.POS.Sucursales().Listar();

                new UI().CargarCombo(dtSucursales, this.cmbSedeOrigen);

            }
            catch (Exception e)
            {

                MessageBox.Show("Se ha provocado un error al  intentar cagar el combo de sedes", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
         }
        private void CargarComboSedesDestino()
        {
            try
            {
                DataTable dtSedes = new HCSoft.POS.Sucursales().Listar();
                new UI().CargarCombo(dtSedes, this.cmbSucursalDestino);
            }
            catch (Exception e)
            {

                MessageBox.Show("Se ha provocado un error al  intentar cagar el combo de sedes", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
        
        }

        private void btnBuscarProductoporCodigo_Click_1(object sender, EventArgs e)
        {
            FrmDialogProductos form = new FrmDialogProductos();

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                int idproductoseleccionado = form.idproducto;
              /*  ObjProducto productoseleccionado = new Productos().TraerPorId(idproductoseleccionado);
                //values preserved after close

                this.txtIdProducto.Text = productoseleccionado.Id.ToString();
                this.txtCodigo.Text = productoseleccionado.Codigo.ToString();
                this.txtDescripcion.Text = productoseleccionado.Nombre.ToString();*/
                

            }
           
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
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
              //  this.txtIdProveedor.Text = proveedorseleccionado.Rows[0]["id"].ToString();
              //  this.txtProveedor.Text = proveedorseleccionado.Rows[0]["nombre"].ToString();


            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSedeOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                this.CargarBodegasOrigen();
           
        }

        private void cmbSucursalDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarBodegasDestino();
        }
    }
}
