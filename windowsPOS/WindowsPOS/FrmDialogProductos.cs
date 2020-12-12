using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HCSoft.POS.Objetos;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmDialogProductos : Form
    {
        //public string retornovalor;
        //public string nombre;
        //public int idproducto;
        public string tipooperacion = string.Empty;
        public List<ObjProducto>  listadoproductos;
        public ObjProducto productoseleccionado;
        public int idproducto;

        public FrmDialogProductos()
        {
            InitializeComponent();
        }

        private void FrmDialogProductos_Load(object sender, EventArgs e)
        {
            this.GrillaProducto.AutoGenerateColumns = false;
            this.txtBusqueda.Focus();

            if (tipooperacion == "LPOS")
            {
                this.txtBusqueda.Focus();
                this.GrillaProducto.DataSource = listadoproductos;
            
            }

        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {

            BuscarProductos();
        
        }


        private void BuscarProductos()
        {

            try
            {
                DataTable listado = new Productos().Buscar(this.txtBusqueda.Text);
                this.GrillaProducto.DataSource = listado;
            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("Busqueda de Productos", ex);
                MessageBox.Show("Se Ha Probocado un error al Buscar Productos");
            }
        }

        private void GrillaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                int fila = e.RowIndex + 1 ;
                this.idproducto = Int32.Parse(this.GrillaProducto.SelectedRows[fila ].Cells[3].Value.ToString());
                
                this.DialogResult = DialogResult.OK;
                this.Close();   
                //retornovalor = codigo;

            }*/
        }

        private void GrillaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
                    int fila = e.RowIndex;
                    this.idproducto = Int32.Parse(this.GrillaProducto.Rows[fila].Cells["id"].Value.ToString());

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    //retornovalor = codigo;

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarProductos();
            }
        }

        private void GrillaProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.GrillaProducto.Rows.Count > 0)
                {
                    if (this.GrillaProducto.Columns[e.ColumnIndex].Name == "Imagen")
                    {
                        string imagen = this.GrillaProducto.Rows[e.RowIndex].Cells["NombreImagen"].Value.ToString();
                        string rutaimagenes = "";
                        rutaimagenes = new HCSoft.Base.Configuracion().ObtieneRutaImagenes();

                        if (rutaimagenes == null)
                        {
                            throw new Exception("Debe Configurar el Path de las imagenes");
                        }

                        imagen = rutaimagenes + imagen;
                        this.GrillaProducto.Rows[e.RowIndex].Height = 100;

                        if (new HCSoft.Util.Archivos().VerificaExistencia(imagen))
                        { e.Value = Image.FromFile(imagen); }
                        else
                        {

                            e.Value = Image.FromFile(rutaimagenes + new HCSoft.Base.Configuracion().ObtieneImagenDefecto());
                        }

                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Se ha provocado un error al cargar las imagenes!", "Error",
           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
