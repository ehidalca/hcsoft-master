using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmDialogUnidades : Form
    {
        public int unidadId;
        public string tipoOperacion;

        public FrmDialogUnidades()
        {
            InitializeComponent();
        }

        private void FrmDialogUnidades_Load(object sender, EventArgs e)
        {
            try
            {
                this.lblError.Text = "";
                this.btn_Guardar.Enabled = false;

                switch (tipoOperacion)
                {
                    case "A":
                        CargarDatos();
                        this.txtDescripcion.ReadOnly = false;
                        this.txtDescripcion.Focus();
                        this.btn_Guardar.Enabled =true ;
                        break;
                    case "V":
                        CargarDatos();
                        this.btn_Guardar.Enabled = false;
                        this.txtDescripcion.ReadOnly = true;
                        break;
                    case "N":        
                        this.txtDescripcion.Text = "";
                        this.btn_Guardar.Enabled = true;
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            catch (Exception ex)
            {
                new HCSoft.Mensajes().Error(ex);
                throw;
            }
            
        }

        public void CargarDatos()
        {
            try
            {
                DataTable dt = new HCSoft.POS.UnidadesMedida().Consulta(unidadId);
                if (dt.Rows.Count > 0)
                {
                    this.txtDescripcion.Text = dt.Rows[0]["nombre"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

    

        private void Actualizar()
        {
            try
            {

                if (this.txtDescripcion.Text == "")
                {
                    this.lblError.Text = "ingrese la descripción";
                    this.errorProvider1.SetError(this.txtDescripcion, "Obligatorio");
                }

                if (new UnidadesMedida().Actualizar(this.unidadId, this.txtDescripcion.Text, Global.usuarioId))
                {
                    new HCSoft.Mensajes().Actualizado();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void Ingresar()
        {
            try
            {
                if (this.txtDescripcion.Text == "")
                {
                    this.lblError.Text = "ingrese la descripción";
                    this.errorProvider1.SetError(this.txtDescripcion, "Obligatorio");
                }

                if ( new UnidadesMedida().Crear(this.txtDescripcion.Text, Global.usuarioId))
                     {
                       new HCSoft.Mensajes().Ingresado();
                       this.DialogResult = DialogResult.OK;
                       this.Close();
                     }
            }
            catch (Exception ex)
            {

                new HCSoft.Mensajes().Error(ex);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            this.btn_Guardar.Enabled = true;
            this.txtDescripcion.ReadOnly = false;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (tipoOperacion == "N")
            {
                this.Ingresar();
            }
            else
            {
                this.Actualizar();
            }

           
        }
    }
}
