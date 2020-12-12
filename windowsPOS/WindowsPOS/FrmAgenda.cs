using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPOS
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            CargarHoras();
        }


        public void CargarHoras()
        {
            ArrayList arreglo = new ArrayList();

            for (int i = 0; i < 20; i++)
            {

                arreglo.Add((i + 1).ToString());

            }


           // this.grillahora.DataSource = arreglo ;
        
        }
    }
}
