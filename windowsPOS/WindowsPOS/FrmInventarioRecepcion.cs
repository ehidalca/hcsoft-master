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
   

    public partial class FrmInventarioRecepcion : Form
    {
        public int idproducto;
 
        public FrmInventarioRecepcion()
        {
            InitializeComponent();
        }

        private void btnBuscarProductoporCodigo_Click(object sender, EventArgs e)
        {

        }

        private void FrmInventarioRecepcion_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            CargarComboSedes();
            CargarBodegas();
            this.txtCodigo.Focus();
        }

  

        private void  CargarBodegas()
        {
            try
            {
                var sede  =(HCSoft.Util.Item)this.ComboSede.SelectedItem;
                DataTable datos = new DataTable();
                if  (sede.Value != "-"  && sede.Value !="")
                {
                     datos = new HCSoft.POS.Bodegas().ListarPorSucursal(Int32.Parse(sede.Value));
                    
                }

                //new HCSoft.UI().CargarCombo(datos, this.ComboBodegas);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
      
        private void CargarComboSedes()
        {
            try
            {

                DataTable  datos  = new HCSoft.POS.Sucursales().Listar();
                //new HCSoft.UI().CargarCombo(datos, this.ComboSede);

            }
            catch (Exception e)
            {
                new Log(Global.log).GuardaError("error al cargar combo sedes",e);
                MessageBox.Show("se ha provocado un error al cargar el combo sedes", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
         }

       


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
           

        }

        private void CargaDialogProductos() {
             FrmDialogProductos form = new FrmDialogProductos();

                        var result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            int productoId = form.idproducto;
                            DataTable dtProducto = new Productos().Consultar(productoId);

                            if (dtProducto.Rows.Count > 0)
                            {

                                this.txtIdProducto.Text = dtProducto.Rows[0]["id"].ToString();
                                this.txtCodigo.Text = dtProducto.Rows[0]["codigo"].ToString();
                                this.txtDescripcion.Text = dtProducto.Rows[0]["nombre"].ToString();
                            }

                        }

        }

        private void btnBuscarProductoporCodigo_Click_1(object sender, EventArgs e)
        {

            this.CargaDialogProductos();
           
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
         

                this.CargarBodegas();
           
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
            try
            {
                 FrmDialogProveedores form = new FrmDialogProveedores();

                        var result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            int idproveedorseleccionado = form.proveedorId;
                            DataTable   proveedorseleccionado= new Proveedores().TraerPorId(idproveedorseleccionado);
                            this.txtIdProveedor.Text = proveedorseleccionado.Rows[0]["id"].ToString();
                            this.txtProveedor.Text = proveedorseleccionado.Rows[0]["nombre"].ToString();


                        }
            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("", ex);
                MessageBox.Show("se ha provocado un error al cargar cargar el proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
            
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ComboSede_ValueMemberChanged(object sender, EventArgs e)
        {
            CargarBodegas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            bool validaciones = true;
            ErrorProvider error = new ErrorProvider();
            validaciones = Validacion.Requerido(error,this.txtCodigo);
            validaciones = Validacion.Requerido(error,this.txtDescripcion);
            validaciones = Validacion.Requerido(error, this.txtCantidad);

            if (validaciones == false)
            {
                lblError.Text = "Debe Ingresar los Valores Obligatorios:";

            }
            else
            {
                int idproducto = Int32.Parse(this.txtIdProducto.Text);
                int idbodega = Int32.Parse(this.ComboBodegas.SelectedValue.ToString());
                int cantidad = Int32.Parse(this.txtCantidad.Text);
                string numeroDocumento = this.txtOrdenCompra.Text;
                if (new Movimientos().Recepcionar(idproducto, cantidad, numeroDocumento, idbodega))
                {
                    MessageBox.Show("se ha ingresado la recepción de archivos!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (this.txtCodigo.Text == "") {
                    this.CargaDialogProductos();
                }
            }

        }
    }
}
