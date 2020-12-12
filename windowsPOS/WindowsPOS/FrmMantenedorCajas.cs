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
using HCSoft.POS;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmMantenedorCajas : Form
    {
        public FrmMantenedorCajas()
        {
            InitializeComponent();
        }

        private void FrmSedes_Load(object sender, EventArgs e)
        {
            CargarCajas();
            this.GrillaCajas.ReadOnly = true;
           
        }

        private void CargarCajas()
        {

            try
            {
                    this.GrillaCajas.AutoGenerateColumns = false;
                    this.GrillaCajas.DataSource = new Cajas().Listar();
            }
            catch (Exception ex)
            {
                 new HCSoft.Util.Log(Global.log).GuardaError("", ex);
                MessageBox.Show("Se ha provocado un error al cargar las Cajas");
             
            }
        
        }

        private void DataGridSedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DataGridSedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id =Int32.Parse( this.GrillaCajas.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                string nombre   = this.GrillaCajas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                string sucursal = this.GrillaCajas.Rows[e.RowIndex].Cells["Sucursal"].Value.ToString();
                FrmDialogCaja formcaja = new FrmDialogCaja();
                ObjCaja caja = new ObjCaja();
                
                
                formcaja.tipooperacion = "V";
                formcaja.nombre = nombre;
                formcaja.cajaId= id;

                 var result = formcaja.ShowDialog();
                 if (result == DialogResult.OK)
                 {
                     CargarCajas();
                 }
            }
        }

      

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            //FrmDialogProductos form = new FrmDialogProductos();
            
            FrmDialogCaja form = new FrmDialogCaja();
            form.tipooperacion  = "N";
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarCajas();
            
            }


            
           
           // form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
