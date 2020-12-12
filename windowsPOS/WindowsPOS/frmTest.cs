using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using HCSoft.POS;
using HCSoft.POS.Objetos;


namespace HCSoft.POS.WinApp
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

            //new HCSoft.POS.Usuarios(7).Crear("Cesar Chavista", "chavista@gmail.com", "cvhavista", "2019292929292", 2);
           bool resultado = new HCSoft.POS.UnidadesMedida().Eliminar(1, 7);

        }
    }
}
