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
    public partial class frmHistorialValores : Form
    {

        public int productoId;

        public frmHistorialValores()
        {
            InitializeComponent();
        }

        private void frmHistorialValores_Load(object sender, EventArgs e)
        {  /*this.dataGridView1.AutoGenerateColumns = false;
            DataTable dtValores = new HCSoft.POS.Productos().VerHistorialValor(productoId);
            this.dataGridView1.DataSource = dtValores;*/
          
        }
    }
}
