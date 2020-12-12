using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPOS;

namespace HCSoft.POS.WinApp
{
    public partial class FrmDialogSucursales : Form
    {
        public int id;

        public string tipooperacion;
        
        public FrmDialogSucursales()
        {
            InitializeComponent();
        }

        private void FrmDialogSede_Load(object sender, EventArgs e)
        {
           

            this.lblError.Text = "";

            if (tipooperacion == "N")
            {

                this.txtDireccion.ReadOnly = false;
                this.txtTelefono.ReadOnly = false;
                this.txtEncargado.ReadOnly = false;
                this.txtDescripcion.ReadOnly = false;
                this.txtDireccion.Text = "";
                this.txtDescripcion.Text = "";
                this.txtEncargado.Text = "";
                this.txtTelefono.Text = "";
                this.btnEditor.Visible = false;
                
            }
            else
            {
                DataTable dtSucursal = new Sucursales().Consultar(this.id);
                this.txtDescripcion.Text = dtSucursal.Rows[0]["nombre"].ToString();
                this.txtDireccion.Text = dtSucursal.Rows[0]["direccion"].ToString();
                this.txtEncargado.Text = dtSucursal.Rows[0]["encargado"].ToString();
                this.txtTelefono.Text = dtSucursal.Rows[0]["telefono"].ToString();
              
            }
        }

        public void CargarValores(string codigo, string descripcion)
        {

            
            this.txtDescripcion.Text = descripcion;
        
        }

      

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = this.txtDescripcion.Text;
                string direccion = this.txtDireccion.Text;
                string telefono = this.txtTelefono.Text;
                string encargado = this.txtEncargado.Text;


                if (descripcion == "")
                {
                    this.lblError.Text = "El Campo descripción es obligatorio";
                    errorProvider1.SetError(this.txtDescripcion, "requerido");
                    return;
                }
                if (direccion == "")
                {
                    this.lblError.Text = "EL campo dirección es obligatorio";
                    errorProvider1.SetError(this.txtDireccion, "requerido");
                    return;
                }
                if (telefono == "")
                {
                    this.lblError.Text = "EL campo telefono es obligatorio";
                    errorProvider1.SetError(this.txtTelefono, "requerido");
                    return;
                }
                if (encargado == "")
                {
                    this.lblError.Text = "EL campo encargado es obligatorio";
                    errorProvider1.SetError(this.txtEncargado, "requerido");
                    return;
                }

                if (this.tipooperacion == "N")
                {
                    bool respuesta = new Sucursales(7).Crear(descripcion, direccion, telefono, encargado);

                    if (respuesta)
                    {
                        MessageBox.Show("Se ha registrado la sucursal!", "Proceso Existoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    }
                }
                else 
                {

                    int usuarioId = Global.usuarioId;
                    bool respuesta = new Sucursales().Actualizar(id,descripcion, direccion, telefono, encargado,usuarioId);

                    if (respuesta)
                    {
                        MessageBox.Show("Se ha actualizado la sucursal!", "Proceso Existoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtDireccion.ReadOnly = false;
            this.txtTelefono.ReadOnly = false;
            this.txtEncargado.ReadOnly = false;
            this.txtDescripcion.ReadOnly = false;
        }
    }
}
