using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCSoft.Base;
using HCSoft.POS;
using HCSoft.POS.Objetos;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmMantenedorProductos : Form
    {
        public FrmMantenedorProductos()
        {
            InitializeComponent();
        }

        private void ProductosListado_Load(object sender, EventArgs e)
        {
           this.CargarGrilla();
           this.CargarComboCategorias();
           this.AmpliarFilas();
        }

        private void CargarComboCategorias()
        {
            try
            {
                  this.ComboCategorias.DataSource =   new Categorias().Listar();
                  this.ComboCategorias.DisplayMember = "Nombre";
                  this.ComboCategorias.ValueMember = "Id";
            }
            catch (Exception ex)
            {

               new HCSoft.Util.Log(Global.log).GuardaError("",ex);
                MessageBox.Show("Se ha Provocado un error al intentar cargar las Categorias");
            }
        
        }

        private void CargarGrilla()
        {
            try
            {
                this.grillaProductos.AutoGenerateColumns = false;
                this.grillaProductos.DataSource =    new Productos().Listar();
                this.grillaProductos.RowTemplate.Height = 5;

            }
            catch (Exception ex)
            {
                new HCSoft.Util.Log(Global.log).GuardaError("", ex);
                MessageBox.Show("Se ha Provocado un error al cargar los productos");

            }
            

        }

        private void AmpliarFilas()
        {

            foreach(DataGridViewRow dg in this.grillaProductos.Rows)
            {
                dg.Height = 1000;
            
            }

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
          

            FrmProductos form = new FrmProductos();
            form.tipooperacion = "N";
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.CargarGrilla();
            }
        }

        private void grillaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grillaProductos.Rows.Count > 1)
            {
                if (this.grillaProductos.Columns[e.ColumnIndex].Name == "Imagen")
                {
                    string imagen = this.grillaProductos.Rows[e.RowIndex].Cells["NombreImagen"].Value.ToString();
                    string rutaimagenes = "";
                    rutaimagenes = Global.rutaImagenes;
                   
                    imagen = rutaimagenes + imagen;
                    this.grillaProductos.Rows[e.RowIndex].Height = 100;

                    if (new Archivos().VerificaExistencia(imagen))
                    { e.Value = Image.FromFile(imagen); }
                    else
                    {

                        e.Value = Image.FromFile(rutaimagenes + Global.imagenDefecto);
                    }

                }
            }
        }

        private void ComboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                this.grillaProductos.DataSource = new Productos().Consultar(Int32.Parse(ComboCategorias.SelectedValue.ToString()));
          
            }
        }

        private void grillaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {

                   
                    FrmProductos productos = new FrmProductos();
                    int id = Int32.Parse(this.grillaProductos.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    productos.producto_id = id;
                    productos.tipooperacion = "V";
                    productos.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha probocado un error al intentar carga el detalle del producto");
                new Log(Global.log).GuardaError("", ex);
                
            }
          
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProductos form = new FrmProductos();
            form.tipooperacion = "N";
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.CargarGrilla();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grillaProductos.SelectedRows != null)
                {
                    FrmProductos form = new FrmProductos();
                    int index = this.grillaProductos.SelectedRows[0].Index;
                    form.tipooperacion = "A";
                    form.producto_id = Int32.Parse(this.grillaProductos.Rows[index].Cells["id"].Value.ToString());
                    var result = form.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        this.CargarGrilla();

                    }

                }
                else
                {

                    MessageBox.Show("Debe seleccionar un registro", "Información",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                throw;
            }
           


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new UI().ConfirmaEliminacion(this.grillaProductos, "nombre"))
            {
                int productoId = Int32.Parse(this.grillaProductos.SelectedRows[0].Cells["id"].Value.ToString());
                if (new HCSoft.POS.Productos().Eliminar(1,productoId))
                {
                    CargarGrilla();
                    new HCSoft.Mensajes().Eliminado();
                }


            }

        }
    }
}
