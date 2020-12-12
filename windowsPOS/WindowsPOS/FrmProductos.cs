using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HCSoft.POS;
using HCSoft.POS.Negocio;
using HCSoft.POS.Objetos;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmProductos : Form
    {
        public int producto_id;
        public string tipooperacion;

        public FrmProductos()
        {
            InitializeComponent();
        }

     
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.lblError.Text = "";
            CargarComboCategorias();
            CargarGrillaProveedores();
            CargarComboUnidadMedida();

            

            if (tipooperacion=="A" || tipooperacion== "V")
            {

                DataTable producto = new Productos().Consultar(producto_id);

                this.txtCodigo.Text = producto.Rows[0]["codigo"].ToString();
                this.txtNombre.Text = producto.Rows[0]["nombre"].ToString();
                this.txtDescripcion.Text = producto.Rows[0]["descripcion"].ToString();
                this.txtValor.Text  = producto.Rows[0]["valor"].ToString();
                this.cmbCategoria.SelectedValue = producto.Rows[0]["categoria_id"].ToString();
                this.CmbUnidadMedida.SelectedValue = producto.Rows[0]["unidad_medida_id"].ToString();

                //this.txtValor.Text =  producto.Rows[0]["valor"].ToString();
                //this.txtCosto.Text = producto.Costo.ToString("N0");

                string rutaimagenes = "";
                rutaimagenes = Global.rutaImagenes;
                string pathimagen = rutaimagenes + producto.Rows[0]["imagen"].ToString();

                this.openFileDialog1.FileName = pathimagen;

                if (new HCSoft.Util.Archivos().VerificaExistencia(pathimagen))
                {
                    this.pictureBox1.ImageLocation = rutaimagenes + producto.Rows[0]["imagen"].ToString();
                }
                else
                {
                    this.pictureBox1.ImageLocation = rutaimagenes + Global.imagenDefecto;
                }
            }

            if (tipooperacion == "A" || tipooperacion=="N")
            {

                this.txtCodigo.ReadOnly = false;
                this.txtNombre.ReadOnly = false;
                this.txtDescripcion.ReadOnly = false;
                this.txtValor.ReadOnly = false;
                this.cmbCategoria.Enabled = true;
                this.CmbUnidadMedida.Enabled = true;
                this.button1.Enabled = true;

            }
            else {

                this.txtCodigo.ReadOnly = true  ;
                this.txtNombre.ReadOnly = true ;
                this.txtDescripcion.ReadOnly = true ;
                this.txtValor.ReadOnly = true;
                this.cmbCategoria.Enabled = false;
                this.CmbUnidadMedida.Enabled =false;
                this.button1.Enabled = false;
            }
        }

        private void CargarComboCategorias()
        {
            try
            {
                DataTable categoriasDt = new Categorias().Listar();
                new UI().CargarCombov2(this.cmbCategoria, categoriasDt, "Nombre", "id");
               
       
                
            }
            catch (Exception ex)
            {
              new Log(Global.log).GuardaError("" , ex);
                MessageBox.Show("Se ha provocado un error al cargar la grilla de categorias");
            }
        
        }

        private void CargarGrillaProveedores()
        {
            try
            {
                //this.grillaproveedores.AutoGenerateColumns = false;
               // this.grillaproveedores.DataSource = new Proveedores().ListarTodos();
            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("", ex);
                   
                MessageBox.Show("se ha provocado un error al cargar la grilla de proveedores");
                
                
            }
        
        }

        protected void CargarComboUnidadMedida()
        {
            try
            {
                DataTable unidadesDt = new UnidadesMedida().Listar();

                new UI().CargarCombov2(this.CmbUnidadMedida, unidadesDt, "Nombre", "id");

            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("", ex);
                MessageBox.Show("Se ha provocado un error al cargar la unidad de medida");
                throw;
            }
        
        }

        private string CargaImagen()
        {
           // this.openFileDialog1.FileName = null;
            string rutaorigen =  this.openFileDialog1.FileName;
            if (rutaorigen != "openFileDialog1")
            {
                ObjArchivo archivo = new ObjArchivo(rutaorigen);
                string rutadestino =  Global.rutaImagenes + archivo.Archivo;
                new Archivos().Guardar(rutaorigen, rutadestino);
                return archivo.Archivo;
            }

            return Global.rutaImagenes + Global.imagenDefecto;
        }

        private void btnImagen_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string  rutaorigen = this.openFileDialog1.FileName;
                this.pictureBox1.Image = Image.FromFile(rutaorigen);
                //string rutaorigen =  this.openFileDialog1.FileName;
                //ObjArchivo archivo = new ObjArchivo(rutaorigen);              
                //string rutadestino = new Configuracion().ObtieneRutaImagenes() + archivo.Archivo ;
                //new POS.Utilidad.Archivos().Guardar(rutaorigen, rutadestino);
            }
        }

        private void btnDetalleValor_Click(object sender, EventArgs e)
        {
            frmHistorialValores frmValores = new frmHistorialValores();
            frmValores.productoId = producto_id; 
            frmValores.ShowDialog();

        }

       

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.errorProvider1.Clear();
                this.lblError.Text = "";
              
                string codigo = this.txtCodigo.Text;
                string nombre = this.txtNombre.Text.ToUpper();
                string descripcion = this.txtDescripcion.Text;
                int valor = 0;
                if (this.txtValor.Text != "") { 
                   valor = Int32.Parse(this.txtValor.Text);
                }
                
                int categoriaId = Int32.Parse(this.cmbCategoria.SelectedValue.ToString());
                int unidadMedidaId = Int32.Parse(this.CmbUnidadMedida.SelectedValue.ToString());


                if (codigo == "") {
                    this.errorProvider1.SetError(this.txtCodigo, "Campo requerido");
                    lblError.Text="Ingrese el código del producto";
                    return;
                }
               
                if (nombre == "") {
                    errorProvider1.SetError(this.txtNombre, "campo requerido");
                    this.lblError.Text = "Ingrese el nombre del producto";
                    return;
                }

                if (valor == 0)
                {
                    errorProvider1.SetError(this.txtValor, "Campo Requerido");
                    lblError.Text = "Ingrese valor de venta del producto";
                    return;
                }

                if (categoriaId == 0) {
                    errorProvider1.SetError(this.cmbCategoria, "Campo requerido");
                    lblError.Text = "Seleccione una categoria";
                    return;
                }
                
                if (unidadMedidaId == 0) {
                    errorProvider1.SetError(this.CmbUnidadMedida, "Campo Requerido");
                    lblError.Text = "Seleccione una unidad de medida";
                    return;
                }

          
                string imagen = CargaImagen();
                
                if (tipooperacion == "N")
                {
                    if (new Productos().ConsultarPorCodigo(codigo).Rows.Count > 0)
                    {
                        this.errorProvider1.SetError(this.txtCodigo, "Código ya existe");
                        lblError.Text = "Ya existe un producto asociado con este código";
                        return;
                    }
                    
                    if (new Productos().Crear(codigo, nombre, descripcion, imagen, categoriaId,unidadMedidaId,valor))
                    {
                        //new Productos().GuardarPrecio(producto_id, valor); 
                        MessageBox.Show("Producto Registrado!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                else
                {

                    /*if (new Productos().ActualizarProducto(producto_id, nombre, descripcion, imagen, categoriaId,valor))
                    {
                        /*if (new Productos().GetPrecio(producto_id) != valor)
                        {
                            new Productos().GuardarPrecio(producto_id, valor);
                            MessageBox.Show("Producto Actualizado!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }*/

                }


            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("", ex);
                MessageBox.Show("Se ha provocado un error al guardar el producto");
            }

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaorigen = this.openFileDialog1.FileName;
                this.pictureBox1.Image = Image.FromFile(rutaorigen);
                //string rutaorigen =  this.openFileDialog1.FileName;
                //ObjArchivo archivo = new ObjArchivo(rutaorigen);              
                //string rutadestino = new Configuracion().ObtieneRutaImagenes() + archivo.Archivo ;
                //new POS.Utilidad.Archivos().Guardar(rutaorigen, rutadestino);
            }
        }
    }
}
