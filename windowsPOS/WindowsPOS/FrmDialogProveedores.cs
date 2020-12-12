using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCSoft.POS.Objetos;
using HCSoft.POS.Negocio;

namespace HCSoft.POS.WinApp
{
    public partial class FrmDialogProveedores : Form
    {
       
        public string tipooperacion = string.Empty;
        public int proveedorId;

        public FrmDialogProveedores()
        {
            InitializeComponent();
        }

        private void FrmDialogProductos_Load(object sender, EventArgs e)
        {
            this.GrillaProducto.AutoGenerateColumns = false;
            this.GrillaProducto.DataSource = new HCSoft.POS.Proveedores().Listar();
          
          

        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            try
                {
                   // DataTable listado = new new Proveedores().Buscar(this.txtBusqueda.Text);
                   // this.GrillaProducto.DataSource = listado;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se Ha Probocado un error al Buscar Productos");
            }

            
        
        }

        private void GrillaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
                    int fila = e.RowIndex;
                    this.proveedorId = Int32.Parse(this.GrillaProducto.SelectedRows[fila].Cells["id"].Value.ToString());
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    //retornovalor = codigo;

                }
            }
        }

        

    }
}
