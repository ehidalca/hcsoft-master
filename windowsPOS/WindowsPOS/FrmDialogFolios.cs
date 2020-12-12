using System;
using System.Data;
using System.Windows.Forms;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmDialogFolios : Form
    {
        public int folioId =0;
        public string tipoOperacion;
         
        public FrmDialogFolios()
        {
            InitializeComponent();
        }

        private void FrmDialogFolios_Load(object sender, EventArgs e)
        {
            this.lblError.Text="";
            this.CargaTipoDocumento();
            this.CargaCajas();
            if (folioId != 0) {
                CargarDatos();
            }
        }

        private void CargaTipoDocumento()
        {
            try
            {
               
                DataTable dtTipoDocumentos = new HCSoft.POS.TipoDocumento().Listar();
                if (dtTipoDocumentos.Rows.Count > 0) {
                    this.cmbTipoDocumento.DataSource = dtTipoDocumentos;
                    this.cmbTipoDocumento.DisplayMember = "nombre";
                    this.cmbTipoDocumento.ValueMember = "id";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargaCajas()
        {
            try
            {
                DataTable dtCajas = new HCSoft.POS.Cajas().Listar();
                if (dtCajas.Rows.Count > 0)
                {
                    this.cmbCajas.DataSource = dtCajas;
                    this.cmbCajas.DisplayMember = "nombre";
                    this.cmbCajas.ValueMember = "id";

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarDatos() {

            try
            {
                DataTable dtFolios = new HCSoft.POS.Folios().Obtiene(folioId);
                if (dtFolios.Rows.Count > 0){
                    this.cmbCajas.SelectedValue= dtFolios.Rows[0]["cajaId"].ToString();
                    this.cmbTipoDocumento.SelectedValue = dtFolios.Rows[0]["tipoDocumentoId"].ToString();
                    this.txtFolioInicial.Text = dtFolios.Rows[0]["folioINicial"].ToString();
                    this.txtFolioSiguiente.Text = dtFolios.Rows[0]["folioSiguiente"].ToString();
                    this.txtFolioTermino.Text = dtFolios.Rows[0]["folioTermino"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Ingresar() {
            try
            {
               
               

                if (this.txtFolioInicial.Text == "") {

                    lblError.Text = "El campo folio inicial es obligatorio";
                    errorProvider1.SetError(this.txtFolioInicial, "Requerido");
                    return ;
                }

                if (this.txtFolioTermino.Text == "")
                {

                    lblError.Text = "El campo folio Termino es obligatorio";
                    errorProvider1.SetError(this.txtFolioTermino, "Requerido");
                    return;
                }


                if (this.txtFolioSiguiente.Text == "")
                {

                    lblError.Text = "El campo folio Siguiente es obligatorio";
                    errorProvider1.SetError(this.txtFolioSiguiente, "Requerido");
                    return;
                }


                int cajaId = Int32.Parse(this.cmbCajas.SelectedValue.ToString());
                int tipoDocumentoId = Int32.Parse(this.cmbTipoDocumento.SelectedValue.ToString());
                string folioInicial = this.txtFolioInicial.Text;
                string folioTermino = this.txtFolioTermino.Text;
                string folioSiguiente = this.txtFolioSiguiente.Text;

                bool respuesta = new HCSoft.POS.Folios().Ingresar(cajaId, tipoDocumentoId, folioInicial, folioTermino, folioSiguiente);

                if (respuesta) {
                    this.DialogResult = DialogResult.OK;

                    MessageBox.Show("Registro Ingresado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception e)
            {
                new Log(Global.log).GuardaError("Ingreso de Folios", e);
                MessageBox.Show("Se ha provocado un error al ingresar la configuración de folios!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Actualizar()
        {
            try
            {
                if (this.txtFolioInicial.Text == "")
                {

                    lblError.Text = "El campo folio inicial es obligatorio";
                    errorProvider1.SetError(this.txtFolioInicial, "Requerido");
                    return;
                }

                if (this.txtFolioTermino.Text == "")
                {

                    lblError.Text = "El campo folio Termino es obligatorio";
                    errorProvider1.SetError(this.txtFolioTermino, "Requerido");
                    return;
                }


                if (this.txtFolioSiguiente.Text == "")
                {

                    lblError.Text = "El campo folio Siguiente es obligatorio";
                    errorProvider1.SetError(this.txtFolioSiguiente, "Requerido");
                    return;
                }

                int cajaId = Int32.Parse(this.cmbCajas.SelectedValue.ToString());
                int tipoDocumentoId = Int32.Parse(this.cmbTipoDocumento.SelectedValue.ToString());
                string folioInicial = this.txtFolioInicial.Text;
                string folioTermino = this.txtFolioTermino.Text;
                string folioSiguiente = this.txtFolioSiguiente.Text;

                bool respuesta = new HCSoft.POS.Folios().Actualizar(folioId, cajaId, tipoDocumentoId, folioInicial, folioTermino, folioSiguiente);

                if (respuesta)
                {
                    this.DialogResult = DialogResult.OK;

                    MessageBox.Show("Registro Actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void tbnGuardar_Click(object sender, EventArgs e)
        {
            if (tipoOperacion == "N")
            {

                Ingresar();

            }
            else{

                Actualizar();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
