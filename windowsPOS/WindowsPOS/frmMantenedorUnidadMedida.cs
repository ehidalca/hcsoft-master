using System;
using System.Data;
using System.Windows.Forms;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class frmMantenedorUnidadMedida : Form
    {
        public frmMantenedorUnidadMedida()
        {
            InitializeComponent();
        }

        private void frmMantenedorUnidadMedida_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        protected void CargarGrilla()
        {

            try
            {
                DataTable dt = new HCSoft.POS.UnidadesMedida().Listar();
                if (dt.Rows.Count > 0)
                {
                    this.GrillaUnidadMedida.AutoGenerateColumns = false;
                    this.GrillaUnidadMedida.AllowUserToAddRows = false;
                    this.GrillaUnidadMedida.DataSource = dt;

                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new UI().ConfirmaEliminacion(this.GrillaUnidadMedida, "nombre"))
            {
                int unidadId = Int32.Parse(this.GrillaUnidadMedida.SelectedRows[0].Cells["id"].Value.ToString());
            
                new HCSoft.POS.UnidadesMedida().Eliminar(unidadId, 3);
                new HCSoft.Mensajes().Eliminado();
                this.CargarGrilla();
            }
        
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                int index = this.GrillaUnidadMedida.SelectedRows[0].Index;
                int unidadId = Int32.Parse(this.GrillaUnidadMedida.Rows[index].Cells["id"].Value.ToString());
                FrmDialogUnidades frm = new FrmDialogUnidades();
                frm.unidadId = unidadId;
                frm.tipoOperacion = "A";

                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.CargarGrilla();
                }

            }
            catch (Exception error)
            {

                new HCSoft.Mensajes().Error(error);
            }
        }

        private void GrillaUnidadMedida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {

                int unidadId = Int32.Parse(this.GrillaUnidadMedida.Rows[e.RowIndex].Cells["id"].Value.ToString());
                FrmDialogUnidades frmUnidades = new FrmDialogUnidades();
                frmUnidades.unidadId = unidadId;
                frmUnidades.tipoOperacion = "V";
                frmUnidades.ShowDialog();
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDialogUnidades frm = new FrmDialogUnidades();
            frm.tipoOperacion = "N";

            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.CargarGrilla();
            }
        }
    }
}
