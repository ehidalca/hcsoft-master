using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCSoft.POS;
using HCSoft.POS.Negocio;

namespace HCSoft.POS.WinApp
{
    public partial class FrmPerfil : Form
    {
        public int idusuario;

        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            CargarComboPerfiles();
        }

        private void CargarComboPerfiles()
        {
            try
            {
                // this.CMBPerfil.DataSource = new Acceso().RolesListar(idusuario);
                //this.CMBPerfil.DisplayMember = "Nombre";
               //this.CMBPerfil.ValueMember = "Id"; 
            }
            catch (Exception)
            {
                
                throw;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
           // principal.idusuario = idusuario;
            principal.Show();
            this.Close();
            
        }
    }
}
