using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCSoft.POS.WinApp
{
    public partial class FrmFolios : Form
    {
        public FrmFolios()
        {
            InitializeComponent();
        }

        private void FrmFolios_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
               
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void CargarDatos()
        {

            this.datagridfolios.AutoGenerateColumns = false;
            this.datagridfolios.DataSource = new HCSoft.POS.Folios().listar();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDialogFolios formFolios = new FrmDialogFolios();
                formFolios.tipoOperacion = "N";

                var result = formFolios.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void datagridfolios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {

                FrmDialogFolios frmFolios = new FrmDialogFolios();
                int id = Int32.Parse(this.datagridfolios.Rows[e.RowIndex].Cells["id"].Value.ToString());
                frmFolios.folioId = id;
                frmFolios.tipoOperacion = "A";
                var result = frmFolios.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarDatos();
                }

            }
        }
    }
}
