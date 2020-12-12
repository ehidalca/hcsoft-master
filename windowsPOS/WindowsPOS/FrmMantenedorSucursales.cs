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
using HCSoft.Util;
namespace WindowsPOS
{
    public partial class FrmSedes : Form
    {
        public FrmSedes()
        {
            InitializeComponent();
        }

        private void FrmSedes_Load(object sender, EventArgs e)
        {
            CargarSedes();
        }

        private void CargarSedes()
        {

            try
            {
                this.DataGridSedes.AutoGenerateColumns = false;
                /*this.DataGridSedes.DataSource = new HCSoft.POS.Sucursales().Listado();*/
            }
            catch (Exception ex)
            {
                new HCSoft.Util.Log().GuardaError("sedes", ex);
                MessageBox.Show("Se ha provocado un error al Cargar el Listado de Sedes");
             
            }
        
        }

        private void DataGridSedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DataGridSedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id =Int32.Parse( this.DataGridSedes.Rows[e.RowIndex].Cells[3].Value.ToString());
                string codigo = this.DataGridSedes.Rows[e.RowIndex].Cells[1].Value.ToString();
                string nombre   = this.DataGridSedes.Rows[e.RowIndex].Cells[2].Value.ToString();
                FrmDialogSede sede = new FrmDialogSede();
                sede.CargarValores(codigo, nombre);
                sede.ShowDialog();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDialogSede form = new FrmDialogSede();
            form.tipooperacion = "N";
            form.ShowDialog();
        }
    }
}
