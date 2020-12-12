using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPOS
{
    public partial class FrmDialogSede : Form
    {
        public string tipooperacion;
        

        public FrmDialogSede()
        {
            InitializeComponent();
        }

        private void FrmDialogSede_Load(object sender, EventArgs e)
        {
            if (tipooperacion == "N")
            {
                this.txtCodigo.Text = "";
                this.txtDescripcion.Text = "";
                this.txtCodigo.ReadOnly = false;
                this.txtDescripcion.ReadOnly = false;
            }
        }

        public void CargarValores(string codigo, string descripcion)
        {

            this.txtCodigo.Text = codigo;
            this.txtDescripcion.Text = descripcion;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
