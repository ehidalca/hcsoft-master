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
using HCSoft.POS.Data;
using HCSoft.POS; 
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmMantenedorCategorias : Form
    {
        public FrmMantenedorCategorias()
        {
            InitializeComponent();
        }

        private void FrmSedes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            
            this.GrillaCategorias.ReadOnly = true;
           
        }

        private void CargarGrilla()
        {

            try
            {
                    this.GrillaCategorias.AutoGenerateColumns = false;
                    this.GrillaCategorias.DataSource = new Categorias().Listar();
            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("carga de datos", ex);
                MessageBox.Show("Se ha provocado un error al Cargar el Listado de Sedes");
             
            }
        
        }

        private void DataGridSedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0) {
                int id = int.Parse( this.GrillaCategorias.Rows[e.RowIndex].Cells["id"].Value.ToString());
                FrmDialogCategorias form = new FrmDialogCategorias();
                form.idcategoria = id;
                form.tipooperacion = "V";
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.CargarGrilla();

                }

            }

        }

        private void DataGridSedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         /*   if (e.ColumnIndex == 0)
            {
                int id =Int32.Parse( this.GrillaCategorias.Rows[e.RowIndex].Cells[3].Value.ToString());
                //string codigo = this.GrillaCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
               // string nombre   = this.GrillaCategorias.Rows[e.RowIndex].Cells[2].Value.ToString();
                
                FrmDialogCategorias frmcategoria = new FrmDialogCategorias();
                frmcategoria.idcategoria = id;
                ObjCategoria categoria = new ObjCategoria();
           
              
                frmcategoria.tipooperacion = "V";
               // frmcategoria.categoria = categoria;

                 var result = frmcategoria.ShowDialog();
                 if (result == DialogResult.OK)
                 {
                     CargarGrilla();
                 }
            }*/
        }

      
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            //FrmDialogProductos form = new FrmDialogProductos();

           // form.ShowDialog();
        }

        private void btn_nuevacategoria_Click(object sender, EventArgs e)
        {

            FrmDialogCategorias form = new FrmDialogCategorias();
            form.tipooperacion = "N";
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.CargarGrilla();

            }

        }

        private void GrillaCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (GrillaCategorias.Rows.Count > 1)
            {
                if (this.GrillaCategorias.Columns[e.ColumnIndex].Name == "Imagen")
                {
                    string imagen = this.GrillaCategorias.Rows[e.RowIndex].Cells["nombreImagen"].Value.ToString();
                    string rutaimagenes = "";
                    rutaimagenes = Global.rutaImagenes;
                    
                  
                    string ubicacionImagen = rutaimagenes + imagen;
                    this.GrillaCategorias.Rows[e.RowIndex].Height = 100;

                    if (new Archivos().VerificaExistencia(ubicacionImagen))
                    { e.Value = Image.FromFile(ubicacionImagen); }
                    else
                    {

                        e.Value = Image.FromFile(rutaimagenes + Global.imagenDefecto);
                    }

                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            

            FrmDialogCategorias form = new FrmDialogCategorias();
            form.tipooperacion = "N";
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.CargarGrilla();
            }
        
    }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.GrillaCategorias.SelectedRows !=null)
            {

                int categoriaId = Int32.Parse(this.GrillaCategorias.SelectedRows[0].Cells["id"].Value.ToString());
            
                    

                FrmDialogCategorias form = new FrmDialogCategorias();
                form.idcategoria = categoriaId;
                form.tipooperacion = "U";

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.CargarGrilla();
                }


            }
            else
            {
                MessageBox.Show("Seleccione un objeto de la Lista", "Información",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (new UI().ConfirmaEliminacion(this.GrillaCategorias, "nombre"))
            {
                int categoriaId = Int32.Parse(this.GrillaCategorias.SelectedRows[0].Cells["id"].Value.ToString());
                if (new HCSoft.POS.Categorias().Eliminar(categoriaId))
                {
                    CargarGrilla();
                    new HCSoft.Mensajes().Eliminado();
                }


            }

           
        }
    }
}





