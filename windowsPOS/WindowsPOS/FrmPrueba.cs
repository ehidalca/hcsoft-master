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
    public partial class FrmPrueba : Form
    {
        public FrmPrueba()
        {
            InitializeComponent();
        }

        private void FrmPrueba_Load(object sender, EventArgs e)
        {
            try
            {
                new HCSoft.POS.Cajas(1).Crear("Caja 100", 1);
               
                /*
                foreach (DataRow dr in dt.Rows)
                {
                    Console.WriteLine(dr[0].ToString());
                }*/
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
