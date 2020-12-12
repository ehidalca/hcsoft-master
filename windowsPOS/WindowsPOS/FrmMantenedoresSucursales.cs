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
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmMantenedorSucursales : Form
    {
        public FrmMantenedorSucursales()
        {
            InitializeComponent();
        }

        private void FrmSedes_Load(object sender, EventArgs e)
        {
            CargarSucursales();
        }

        private void CargarSucursales()
        {
            try
            {
                this.DataGridSedes.AutoGenerateColumns = false;
                this.DataGridSedes.DataSource = new Sucursales().Listar();
            }
            catch (Exception ex)
            {
                new Log(Global.log).GuardaError("sedes", ex);
                MessageBox.Show("Se ha provocado un error al cargar el listado de Sedes");
             
            }
        }

        private void DataGridSedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DataGridSedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id =Int32.Parse( this.DataGridSedes.Rows[e.RowIndex].Cells["id"].Value.ToString());
                //string codigo = this.DataGridSedes.Rows[e.RowIndex].Cells[1].Value.ToString();
                //string nombre   = this.DataGridSedes.Rows[e.RowIndex].Cells[2].Value.ToString();
                
                FrmDialogSucursales sucursal = new FrmDialogSucursales();
                sucursal.tipooperacion = "V";
                sucursal.id = id;
                sucursal.ShowDialog();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDialogSucursales form = new FrmDialogSucursales();
            form.tipooperacion = "N";
            form.ShowDialog();
        }
    }
}
