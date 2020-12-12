using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HCSoft.POS;
using WindowsPOS;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmMantenedorUsuarios : Form
    {
        public int usuarioId;
        public string tipoOperacion;

        public FrmMantenedorUsuarios()
        {
            InitializeComponent();
        }

        private void FrmMantenedorUsuarios_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        public void CargarDatos()
        {
            try
            {
              
                DataTable dtUsuarios = new Usuarios().Listar();
                this.gridViewUsuarios.DataSource = dtUsuarios;
     
            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("carga de la grilla", ex);
            }
            

        }

        private void gridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) {

                int id = int.Parse( this.gridViewUsuarios.Rows[e.RowIndex].Cells["id"].Value.ToString());
                FrmDialogUsuario frmUsuarios = new FrmDialogUsuario();
                frmUsuarios.tipooperacion = "V";
                frmUsuarios.id  = id;
                frmUsuarios.ShowDialog();
            }
        }

        private void gridViewUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.gridViewUsuarios.Rows.Count > 1)
                {
                    if (this.gridViewUsuarios.Columns[e.ColumnIndex].Name == "Imagen")
                    {
                        string imagen = this.gridViewUsuarios.Rows[e.RowIndex].Cells["Imagen"].Value.ToString();

                        string rutaimagenes = Global.rutaImagenesUsuarios;

                        if (imagen == "")
                        {
                            imagen = Global.imagenDefecto;
                        }

                        imagen = rutaimagenes + imagen;
                        this.gridViewUsuarios.Rows[e.RowIndex].Height = 100;

                        if (new HCSoft.Util.Archivos().VerificaExistencia(imagen))
                        { e.Value = Image.FromFile(imagen); }

                    }
                }
            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("Carga de imagenes en grilla", ex);
               
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDialogUsuario frmUsuarios = new FrmDialogUsuario();
            frmUsuarios.tipooperacion = "N";
            frmUsuarios.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new UI().ConfirmaEliminacion(this.gridViewUsuarios, "nombre"))
            {
                int usuarioId = Int32.Parse(this.gridViewUsuarios.SelectedRows[0].Cells["id"].Value.ToString());
                if (new HCSoft.Base.Usuario().Eliminar(usuarioId))
                {
                    CargarDatos();
                    new HCSoft.Mensajes().Eliminado();
                }


            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridViewUsuarios.SelectedRows != null)
                {
                    FrmDialogUsuario form = new FrmDialogUsuario();
                    int index = this.gridViewUsuarios.SelectedRows[0].Index;
                    form.tipooperacion = "A";
                    form.id = Int32.Parse(this.gridViewUsuarios.Rows[index].Cells["id"].Value.ToString());
                    var result = form.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        this.CargarDatos();
                    }

                }
                else
                {

                    MessageBox.Show("Debe seleccionar un registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("Error al Actualizar Usuario", ex);            
            }

        }
    }
}
