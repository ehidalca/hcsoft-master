using System;
using System.Data;
using HCSoft.Util;
using MySql.Data.MySqlClient;


namespace HCSoft.POS
{
    public class Categorias
    {

        private int usuarioId;

        public Categorias()
        { }

        public Categorias(int usuarioId) 
        {
            this.usuarioId = usuarioId;
        }

        public DataTable Listar()
        {
            try
            {
                string query = "SELECT *  FROM categorias WHERE  eliminado = 0";
                return new MyCon().EjecutaConsulta(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Consultar(int id)
        {
            try
            {
                string query = "SELECT * FROM categorias WHERE id=@id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id", id)
                };

                return new MyCon().EjecutaConsulta(query, parametros);

            }
            catch (Exception)
            {

                throw;
            }
            

        }

        public bool Crear(string nombre, string imagen)
        {
            try
            {
                DateTime fechaHoraCreacion = DateTime.Now;
                string query = "INSERT INTO categorias(nombre, imagen, fecha_hora_creacion, usuario_creacion_id) values(@nombre, @imagen,@fecha_hora_creacion, @usuario_creacion_id)";
                MySqlParameter[] parametros = {
                    new MySqlParameter("nombre", nombre),
                    new MySqlParameter("imagen", imagen),
                    new MySqlParameter("fecha_hora_creacion", fechaHoraCreacion),
                    new MySqlParameter("usuario_creacion_id", this.usuarioId)

                };
                return new MyCon().EjecutaQuery(query, parametros);
            }
            catch (Exception)
            {

                throw;
            }


        }

        public bool Actualizar(int id,string nombre, string imagen)
        {
            try
            {
                DateTime fechaHoraActualizacion = DateTime.Now;
                string query = "UPDATE categorias SET nombre=@nombre, imagen=@imagen, fecha_hora_actualizacion=@fecha_hora_actualizacion, usuario_actualizacion_id=@usuario_actualizacion_id  WHERE  id=@id ";
                
                   MySqlParameter[] parametros = {
                    new MySqlParameter("id", id),
                    new MySqlParameter("nombre", nombre),
                    new MySqlParameter("imagen", imagen),
                    new MySqlParameter("fecha_hora_actualizacion", fechaHoraActualizacion),
                    new MySqlParameter("usuario_actualizacion_id", this.usuarioId)

                };
                return new MyCon().EjecutaQuery(query, parametros);
            }
            catch (Exception)
            {

                throw;
            }

        }
  
        public bool Eliminar(int id)
        {
            try
            {
                DateTime fechaHoraActualizacion = DateTime.Now;
                string query = "UPDATE categorias SET eliminado=1  WHERE  id=@id ";

                MySqlParameter[] parametros = {
                    new MySqlParameter("id", id),
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
