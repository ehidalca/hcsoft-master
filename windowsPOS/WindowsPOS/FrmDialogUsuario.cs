using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HCSoft.Util;

namespace HCSoft.POS.WinApp
{
    public partial class FrmDialogUsuario : Form
    {
       
        public string tipooperacion;
        public int  id;
        
        public FrmDialogUsuario()
        {
            InitializeComponent();
        }

        private void FrmDialogSede_Load(object sender, EventArgs e)
        {
            try
            {
                //this.CargarGrillaPerfiles();

                this.CargarComboTipoUsuarios();
                if (tipooperacion == "N" || tipooperacion =="A")
                {
                  
                    this.txtEmail.Text = "";
                    this.txtNombre.ReadOnly = false;
                    this.txtUsuario.ReadOnly = false;
                    this.txtPassword.ReadOnly = false;
                    this.txtPassword2.ReadOnly = false;
                    this.txtEmail.ReadOnly = false;
                    this.txtNombre.Focus();
                }

                if (tipooperacion == "V" || tipooperacion=="A")
                {

                    this.CargarDatos();

                }

            }
            catch (Exception ex)
            {
       
                new HCSoft.Mensajes().Error(ex);
            }
        }

        private void CargarComboTipoUsuarios()
        {
            try
            {
                this.cmbTipoUsuario.DataSource = new UsuariosTipo().Listar();
                this.cmbTipoUsuario.ValueMember = "id";
                this.cmbTipoUsuario.DisplayMember = "nombre";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CargarDatos()
        {
            try
            {
                DataTable datosUsuario = new Usuarios().Consultar(this.id);
                if (datosUsuario.Rows.Count  > 0)
                {
                    DataRow fila = datosUsuario.Rows[0];
                    //this.txtCodigo.Text =  fila[""]
                    this.txtUsuario.Text = fila["usuario"].ToString();
                    this.txtEmail.Text = fila["email"].ToString();
                    this.txtNombre.Text = fila["nombre"].ToString();
                    this.txtPassword.Text = fila["password"].ToString();
                    this.txtPassword2.Text= fila["password"].ToString();
                    string imagen = fila["imagen"].ToString();

                    //this.txtFechaCreación.value = DateTime.Parse(fila["fecha_hora_creacion"].ToString()));
                    if (fila["activo"].ToString() == "1")
                    {
                        this.chkActivo.Checked = true ;
                    }
                    
                    string rutaimagenes = Global.rutaImagenesUsuarios;
                    if (imagen == "")
                    {
                        imagen = Global.imagenDefecto;
                    }

                    imagen = rutaimagenes + imagen;
                    this.pictureBox1.ImageLocation = rutaimagenes + fila["imagen"].ToString();
                   
                


                
            }

            }
            catch (Exception error)
            {

                throw;
            }
        }

        protected void CargarGrillaPerfiles()
        {
            try 
	        {
                this.GrillaPerfiles.DataSource = new HCSoft.Base.Perfil().ListarTodo();
	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
                            
            
        }

        private void Crear() {
            try
            {          
                string nombre = this.txtNombre.Text;
                string email = this.txtEmail.Text;
                string usuario = this.txtUsuario.Text;
                string password  = Seguridad.Encriptar(this.txtPassword.Text);
                int usuarioTipoId = Int32.Parse(this.cmbTipoUsuario.SelectedValue.ToString());
               
                //upload de imagen
                string imagen = CargaImagen();
                int usuarioId = Global.usuarioId;

                bool insert = new Usuarios().Crear(nombre, email, usuario, password, imagen,usuarioTipoId, usuarioId);

                if (insert)
                {
                    new HCSoft.Mensajes().Ingresado();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            { 
                new HCSoft.Mensajes().Error(ex);
                throw;
            }
        }

        private void Actualizar()
        {

            try
            {
                string nombre = this.txtNombre.Text;
                string email = this.txtEmail.Text;
                string usuario = this.txtUsuario.Text;
                string password = Seguridad.Encriptar(this.txtPassword.Text);
                string imagen = CargaImagen();
                bool estado = this.chkActivo.Checked;
                bool actualizar = new HCSoft.Base.Usuario().Actualizar(nombre, email, password, usuario, estado, id,imagen);

                if (actualizar)
                {
                    new HCSoft.Mensajes().Actualizado();
                    this.DialogResult = DialogResult.OK;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            this.txtNombre.ReadOnly = false;
            this.txtEmail.ReadOnly = false;
            this.txtPassword.ReadOnly = false;
            this.txtUsuario.ReadOnly = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaorigen = this.openFileDialog1.FileName;
                this.pictureBox1.Image = Image.FromFile(rutaorigen);
  
                //ObjArchivo archivo = new ObjArchivo(rutaorigen);              
                //string rutadestino = new Configuracion().ObtieneRutaImagenes() + archivo.Archivo ;
                //new POS.Utilidad.Archivos().Guardar(rutaorigen, rutadestino);
            }
        }

        private string CargaImagen()
        {
           
            string rutaorigen = this.openFileDialog1.FileName;
            if (rutaorigen != "")
            {
           
                string rutadestino = Global.rutaImagenesUsuarios + this.openFileDialog1.FileName;
                new Archivos().Guardar(rutaorigen, rutadestino);
                return Global.rutaImagenesUsuarios + this.openFileDialog1.FileName;
            }

            return Global.rutaImagenesUsuarios + Global.imagenDefecto;
        }

        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            bool requeridos = true;
            ErrorProvider error = new ErrorProvider();
            requeridos = Validacion.Requerido(error,this.txtNombre);
            requeridos = Validacion.Requerido(error,this.txtUsuario);
            requeridos = Validacion.Requerido(error, this.txtPassword);

            if (!requeridos)
            {
                MessageBox.Show("Los Siguientes campos son requeridos");
                return;
            }

            if (this.tipooperacion == "N")
            {
                Crear();
            }

            if (this.tipooperacion == "A")
            {
                Actualizar();
            }

        }
    }
}
