using System;
using HCSoft.Util;
using System.Data;
using MySql.Data.MySqlClient;

namespace HCSoft.POS
{
    public class Proveedores
    {
        private int usuarioId;

        public Proveedores()
        { }

        public Proveedores(int usuarioId) 
        {
            this.usuarioId = usuarioId;
        }

        public DataTable Listar()
        {
            try
            {
                string query = "SELECT * FROM proveedores";
                return new MyCon().EjecutaConsulta(query);
                
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public DataTable TraerPorId(int id)
        {
            try
            {
                MySqlParameter[] parametros = {
                                    new MySqlParameter("id", id)
                                };
                return new MyCon().EjecutaConsulta("Select * from pos_proveedores where id=@id", parametros);
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }

        public DataTable Buscar( string busqueda)
        {
            try
            {
               return new ConexionMy().EjecutaConsultaDt("SELECT * FROM PROVEEDORES WHERE NOMBRE LIKE '%" + busqueda + "%'");
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool Registrar(string rut, string nombre, string contactoNombre, string telefono, string email, string direccion)
        {
            try
            {
                DateTime fechHoraCreacion = DateTime.Now;
                string query = "INSERT INTO proveedores(rut,nombre, contacto_nombre, telefono, email, direccion) VALUES(@rut, @nombre, @contactoNombre, @telefono, @email, @direccion)";
                MySqlParameter[] parametros = {
                    new MySqlParameter("rut",rut),
                    new MySqlParameter("nombre", nombre),
                    new MySqlParameter("contactoNombre", contactoNombre),
                    new MySqlParameter("telefono", telefono),
                    new MySqlParameter("email", email),
                    new MySqlParameter("direccion", direccion),
                    new MySqlParameter("usuario_creacion_id", this.usuarioId)

                };

                return new MyCon().EjecutaQuery(query, parametros);

            }
            catch (Exception)
            {

                throw;
            }
        
        }
    }
}
