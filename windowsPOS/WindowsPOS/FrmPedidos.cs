using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCSoft;
namespace HCSoft.POS.WinApp
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            CargarSalones();
            CargaEstadoMesas();
        }

        protected void CargarSalones()
        {

            this.cmbSalon.DataSource = new HCSoft.POS.Negocio.Salones().Listar();
            this.cmbSalon.ValueMember = "idSalon";
            this.cmbSalon.DisplayMember = "Nombre";
        
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {

            TomarPedido(2);
        }


        protected void TomarPedido(int idmesa)
        {
            
        }

        protected void CargaEstadoMesas()
        {
            Color ColorMesaAbierta = Color.GreenYellow;
            Color ColorMesaBloqueada = Color.OrangeRed;

            DataTable mesas = new HCSoft.POS.Negocio.Mesas().listar();
            foreach(DataRow dr in mesas.Rows )
            {
                if (dr["codigo"].ToString() == "01" && dr["estado"].ToString() =="1")
                {
                    this.btn_mesa1.BackColor = ColorMesaAbierta;
                }

                if (dr["codigo"].ToString() == "02" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa2.BackColor = ColorMesaAbierta;
                }

                if (dr["codigo"].ToString() == "03" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa3.BackColor = ColorMesaAbierta;
                }

                if (dr["codigo"].ToString() == "04" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa4.BackColor = ColorMesaAbierta;
                }

                if (dr["codigo"].ToString() == "05" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa5.BackColor = ColorMesaAbierta;
                }

                if (dr["codigo"].ToString() == "06" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa6.BackColor = ColorMesaAbierta;
                }


                if (dr["codigo"].ToString() == "07" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa7.BackColor = ColorMesaAbierta;
                }
                if (dr["codigo"].ToString() == "08" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa8.BackColor = ColorMesaAbierta;
                }

                if (dr["codigo"].ToString() == "09" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa9.BackColor = ColorMesaAbierta;
                }

                if (dr["codigo"].ToString() == "10" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa10.BackColor = ColorMesaAbierta;
                }
                if (dr["codigo"].ToString() == "11" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa11.BackColor = ColorMesaAbierta;
                }

                if (dr["codigo"].ToString() == "12" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa12.BackColor = ColorMesaAbierta;
                }

                if (dr["codigo"].ToString() == "13" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa13.BackColor = ColorMesaAbierta;
                }
                if (dr["codigo"].ToString() == "14" && dr["estado"].ToString() == "1")
                {
                    this.btn_mesa14.BackColor = ColorMesaAbierta;
                }



                if (dr["codigo"].ToString() == "01" && dr["estado"].ToString() == "2")
                {
                    this.btn_mesa1.BackColor = ColorMesaBloqueada;
                }

                if (dr["codigo"].ToString() == "02" && dr["estado"].ToString() == "2")
                {
                    this.btn_mesa2.BackColor = ColorMesaBloqueada;
                }
            }
        
        
        
        }

        private void btn_mesa1_Click(object sender, EventArgs e)
        {
            TomarPedido(1);
        }

        private void btn_mesa3_Click(object sender, EventArgs e)
        {
            TomarPedido(3);
        }

        private void btn_mesa4_Click(object sender, EventArgs e)
        {
            TomarPedido(4);
        }

        private void btn_mesa5_Click(object sender, EventArgs e)
        {
            TomarPedido(5);
        }

        private void btn_mesa6_Click(object sender, EventArgs e)
        {
            TomarPedido(6);
        }

        private void btn_mesa7_Click(object sender, EventArgs e)
        {
            TomarPedido(7);
        }

        private void btn_mesa8_Click(object sender, EventArgs e)
        {
            TomarPedido(8);
        }

        private void btn_mesa9_Click(object sender, EventArgs e)
        {
            TomarPedido(9);
        }

    }
}
