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

    public partial class FrmDialogCategorias : Form
    {
        public string tipooperacion;
        public int idcategoria;


        public FrmDialogCategorias()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            try
            {
                string imagen = CargaImagen();

                if (tipooperacion == "N")
                {


                    if (new Categorias().Crear(this.txtDescripcion.Text, imagen))
                    {

                        MessageBox.Show("Categoria Ingresada!");
                       
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                else
                {
                   if (new Categorias().Actualizar(idcategoria, this.txtDescripcion.Text , imagen) )
                    {

                        MessageBox.Show("Registro Actualizado");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }


            }
            catch (Exception ex)
            {

                new HCSoft.Mensajes().Error(ex);
            }
        }

        private void FrmDialogCategorias_Load(object sender, EventArgs e)
        {
            this.lblError.Text = "";
            switch (tipooperacion)
            {
                case "V":
                    this.txtDescripcion.ReadOnly = true;
                    this.btn_Guardar.Enabled = false;
                    this.btnImagen.Enabled = false;
                    this.CargarDatos();
                    break;

                case "N":
                    this.txtDescripcion.ReadOnly = false;
                    break;
                case "U":

                    this.CargarDatos();
                    this.txtDescripcion.ReadOnly = false;
                    
                    break;
                 

            }
        }


        private void CargarDatos() {
            try
            {
                    DataTable dt = new Categorias().Consultar(idcategoria);
                    this.txtDescripcion.Text = dt.Rows[0]["nombre"].ToString();
                    string rutaImagenes = "";

                    rutaImagenes = Global.rutaImagenes;
                    this.pictureBox1.ImageLocation = rutaImagenes + dt.Rows[0]["imagen"].ToString();
                    this.openFileDialog1.FileName = rutaImagenes + dt.Rows[0]["imagen"].ToString();
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        private void btnImagen_Click(object sender, EventArgs e)
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

        private string CargaImagen()
        {
            // this.openFileDialog1.FileName = null;
            string rutaorigen = this.openFileDialog1.FileName;
            if (rutaorigen != "")
            {
                ObjArchivo archivo = new ObjArchivo(rutaorigen);
                string rutadestino = Global.rutaImagenes + archivo.Archivo;
                new Archivos().Guardar(rutaorigen, rutadestino);
                return archivo.Archivo;
            }

            return new Configuracion().ObtieneImagenDefecto();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar:" + this.txtDescripcion.Text, "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (new Categorias().Eliminar(this.idcategoria))
                        {
                            MessageBox.Show("Registro Eliminado Satisfactoriamente",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                       }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
            catch (Exception ex )
            {

                 new Log(Global.log).GuardaError("Busqueda de Productos", ex);
                 MessageBox.Show("Se ha Probocado un Error al Buscar Productos",
                 "Exepción de Sistema",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation,
                 MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            this.Guardar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
