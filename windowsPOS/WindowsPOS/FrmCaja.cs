using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HCSoft.POS.Objetos;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmCaja : Form
    {
        private List<ObjItemCaja> itemCajas =  new List<ObjItemCaja>() ;

        public FrmCaja()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            InicializaFormulario();
        }

        private void InicializaFormulario()
        {
            this.GrillaItems.AutoGenerateColumns = false;
            this.CargarTipoDocumento();
            this.traeFolioCorrespondiente();

        }


        private void traeFolioCorrespondiente()
        {
            try
            {
                int caja_id = 1;
               
                int tipodocumento_id = Int32.Parse(cmbTipoDocumento.SelectedValue.ToString());
                this.txtNroDocumento.Text = new Folios().TraerFolio(caja_id, tipodocumento_id).ToString();
            }
            catch (Exception ex)
            {

                 new Log(Global.log).GuardaError("Caja - traeFolioCorrespondiente", ex);
                 MessageBox.Show("Se ha Probocado un Error al Buscar Productos",
                 "Exepción de Sistema",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation,
                 MessageBoxDefaultButton.Button1);
            }

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {


            BuscarProductos();

        }


        private void FrmCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
           MessageBox.Show("hola");
        }

       

        private void BuscarProductos()
        {

           

        }

        private bool existeproducto(int idproducto, List<ObjItemCaja> itemCajas)
        {
            bool existe = false;
            foreach (ObjItemCaja   item in itemCajas )
            {
                if (idproducto == item.Producto.Id)
                {
                    existe = true;
                }
            }


            return existe;          

        }


        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarProductos();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GrillaItems.Rows.Count == 0)
                {
                    MessageBox.Show("Debe Ingresar items para continuar");
                    return;
                }
                     
                List<ObjItemCaja> itemscaja = new List<ObjItemCaja>();

                if (this.GrillaItems.Rows.Count == 0)
                {
                    MessageBox.Show("Debe Ingresar items para continuar");
                    return;
                }

                int numerodelinea = 1;

                foreach (DataGridViewRow dgr in this.GrillaItems.Rows)
                {
                    string codigo = dgr.Cells[1].Value.ToString();
                    int cantidad = Int32.Parse(dgr.Cells[3].Value.ToString());
                   /* ObjProducto producto = new Productos().ConsultarPorCodigo(codigo);
                    ObjItemCaja item = new ObjItemCaja(producto, numerodelinea,3);
                    numerodelinea = numerodelinea + 1;               */
                    /*itemscaja.Add(item);*/
                }

                DateTime fecha = DateTime.Now;
                int idusuario = 10;
                int idcaja = 1;

                FrmDialogPago pago = new FrmDialogPago();
                pago.total = Double.Parse(this.txtTotal.Text);
                pago.itemscaja = itemscaja;
                pago.idcaja = idcaja;
                pago.idusuario = idusuario;
                pago.fecha = fecha;
                pago.folio = Int32.Parse(this.txtNroDocumento.Text);
                pago.tipodocumento_id = Int32.Parse(this.cmbTipoDocumento.SelectedValue.ToString());
                pago.ShowDialog();

            }
            catch (Exception ex)
            {

                new Log(Global.log).GuardaError("ingreso de venta", ex);
                MessageBox.Show("Se ha Probocado un Error al intentar generar la venta",
                 "Exepción de Sistema",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation,
                 MessageBoxDefaultButton.Button1);
            }
           
        }

        private void CargarTipoDocumento()
        {
            try
            {
                this.cmbTipoDocumento.DataSource = new TipoDocumento().Listar();
                this.cmbTipoDocumento.ValueMember = "id";
                this.cmbTipoDocumento.DisplayMember = "nombre";
               
               
            }
            catch (Exception ex)
            {

                new Log(Global.log  ).GuardaError("Caja combo tipo de documentos", ex);
                MessageBox.Show("Se ha Probocado un Error al cargar los tipos de documentos",
                 "Exepción de Sistema",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation,
                 MessageBoxDefaultButton.Button1);
            }


        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTipoDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            traeFolioCorrespondiente();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }


}
