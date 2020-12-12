using System;
using System.Data;
using System.Windows.Forms;
using HCSoft.POS;

using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmLogin : Form
    {
        public int usuarioId {get;set;} 

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


           // MessageBox.Show(Seguridad.Desencriptar(new Usuario().ObtieneUsuario(10).Password.ToString()));

            lblError.Text = "";  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void Logea()
     {
          try
            {
                string usuario = this.txtUsuario.Text;
                string password = this.txtPassword.Text;

                DataTable dtUsuario = new Usuarios().Consultar(usuario);

                if (dtUsuario.Rows.Count != 0)
                {
                    /*  FrmPerfil perfil = new FrmPerfil();*/
                    /* perfil.idusuario =Int32.Parse( dtacceso.Rows[0]["Id"].ToString());*/

                    // FrmPrincipal frm = new FrmPrincipal();
                    this.usuarioId = Int32.Parse(dtUsuario.Rows[0]["id"].ToString());
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    statusStrip1.Text = "Datos Incorrectos";
                    lblError.Text = "Datos Incorrectos";
                }
               
            }
            catch (Exception ex)
            {
                
               MessageBox.Show("Se Ha Provocado un Error:" + ex.Message.ToString()) ;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Logea();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txtPassword.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            bool validacion = false;
            ErrorProvider error = new ErrorProvider();
            validacion = Validacion.Requerido(error, this.txtUsuario);
            validacion = Validacion.Requerido(error, this.txtPassword);

            if (validacion == true)
            {
                Logea();
            }
            else
            { this.lblError.Text = "Los datos son obligatorios"; }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Logea();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
