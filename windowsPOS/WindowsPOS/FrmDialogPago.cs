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
    public partial class FrmDialogPago : Form
    {
        public double total;
        public DateTime fecha;
        public int idcaja;
        public int idusuario;
        public int folio;
        public int tipodocumento_id;
        public List<HCSoft.POS.Objetos.ObjItemCaja> itemscaja;

        public FrmDialogPago()
        {
            InitializeComponent();
        }

        private void FrmDialogPago_Load(object sender, EventArgs e)
        {
            this.lblTotal.Text = "Total a Pagar: $" + total.ToString("N0");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                   
                 
               //new HCSoft.POS.Ventas().Guardar(new HCSoft.POS.Objetos.ObjVenta(fecha, idcaja,idusuario, total , itemscaja, folio, tipodocumento_id)); 


            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
