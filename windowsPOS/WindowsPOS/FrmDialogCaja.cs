using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCSoft.POS;
using HCSoft.POS.Objetos;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{

    public partial class FrmDialogCaja : Form
    {
        public string tipooperacion;
        public int cajaId;
        public string nombre;
     
        public FrmDialogCaja()
        {
            InitializeComponent();
        }

        private void FrmDialogCaja_Load(object sender, EventArgs e)
        {

            this.lblError.Text = "";

            switch (tipooperacion)
            {
                case "N":
                    this.Text = "Nueva Caja";
                    this.txtDescripcion.ReadOnly = false;
                    CargarComboSucursales();
                    break;
                case "V":
                    //this.txtCodigo.Text = caja.Id.ToString();
                    this.txtDescripcion.Text = nombre;
                    CargarComboSucursales();
                    this.cmbSucursal.SelectedItem= cajaId;
                  
                    break;


            }
        }


        public void CargarComboSucursales()
        {

            try
            {
                DataTable dt = new Sucursales().Listar();
                this.cmbSucursal.DataSource = dt;
                this.cmbSucursal.DisplayMember = "Nombre";
                this.cmbSucursal.ValueMember = "id";
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipooperacion == "N")
                {
                    string descripcion = this.txtDescripcion.Text;
                    int sucursalId = 0;
                    sucursalId = Int32.Parse(this.cmbSucursal.SelectedValue.ToString());

                    if (descripcion == "")
                    {
                        this.lblError.Text = "El campo Descripcion es obligario!";
                        return;
                    }

                    if (sucursalId == 0) 
                    {
                        this.lblError.Text = "Seleccione  una Sucursal";
                        return;
                    }
                    
                    string nombre = this.txtDescripcion.Text;
                    int id = Int32.Parse(this.cmbSucursal.SelectedValue.ToString());
                    if (new Cajas().Crear(nombre, id))
                    {
                        MessageBox.Show("Registro Ingresadoo");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }               

                }

                if (tipooperacion == "V")
                {

                    bool validacion = false;
                    validacion = Validacion.Requerido(this.errorProvider1, this.txtDescripcion);

                    if (validacion)
                    {

                        string nombre = this.txtDescripcion.Text;
                        int sucursalId = int.Parse(this.cmbSucursal.SelectedValue.ToString());
                        int cajaId = this.cajaId;

                        if (new HCSoft.POS.Cajas().Actualizar(cajaId,nombre, sucursalId))
                        {
                            MessageBox.Show("Registro Actualizado");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }

                    }
                    else
                    {
                        lblError.Text = "Los siguientes Datos son Requeridos";

                    }
                }

            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("", ex);
                MessageBox.Show("Se ha provocado un error al guardar la caja");
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.tipooperacion == "N")
            {
               // this.txtCodigo.Text = "";
                this.txtDescripcion.Text = "";
            }
            }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            this.txtDescripcion.ReadOnly = false;
        }

     
    }
    
}
