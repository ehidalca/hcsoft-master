using System;
using HCSoft.Util;
using System.Data;
using MySql.Data.MySqlClient;

namespace HCSoft.POS
{
    public class Bodegas
    {
        private int usuarioId;
        public Bodegas()
        { }

        public Bodegas(int usuarioId)
        {
            this.usuarioId = usuarioId;
        }
       
        public DataTable Listar()
        {
            try
            {
                string query = "SELECT  * FROM bodegas where eliminado=0";
                return new MyCon().EjecutaConsulta(query);
            }
            catch (Exception)
            {

                throw;
            }

        }
       
        public DataTable ListarPorSucursal(int sucursalId)
        {

            try
            {
                string query = "SELECT * FROM bodegas where sucursal_id = @sucursalId";

                MySqlParameter[] parametros = {
                    new MySqlParameter("sucursal_id", sucursalId)
                };

                return new MyCon().EjecutaConsulta(query, parametros);


            }
            catch (Exception)
            {

                throw;
            }


        }
        
        public bool Actualizar(int id, string nombre, int sucursalId)
        {
            try
            {
                DateTime fechaHoraActualizacion = DateTime.Now;
                string query = "UPDATE bodegas  SET nombre =@nombre, sucursal_id=@sucursal_id, fecha_hora_actualizacion=@fecha_hora_actualizacion, usuario_actualizacion_id=@usuario_actualizacion_id WHERE id =@id";

                MySqlParameter[] parametros = {
                    new MySqlParameter("nombre", nombre),
                    new MySqlParameter("sucursal_id", sucursalId),
                    new MySqlParameter("fecha_hora_actualizacion", fechaHoraActualizacion),
                    new MySqlParameter("usuario_actualizacion_id", this.usuarioId),
                    new MySqlParameter("id", id)
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
                string query = "UPDATE bodegas  SET eliminado=1 WHERE id =@id";

                MySqlParameter[] parametros = {
                    new MySqlParameter("id", id)
                };

                return new MyCon().EjecutaQuery(query, parametros);

            }
            catch (Exception)
            {

                throw;
            }

        }
        
        public bool Crear(string nombre,int sucursalId)
        {
            try
            {
                DateTime fechaHoraCreacion = DateTime.Now;
                string query = "INSERT INTO bodegas(nombre,sucursal_id,fecha_hora_creacion, usuario_creacion_id) VALUE(@nombre, @sucursal_id, @fecha_hora_creacion,@usuario_creacion_id) ";
                MySqlParameter[] parametros = {
                    new MySqlParameter("nombre",nombre),
                    new MySqlParameter("sucursal_id", sucursalId),
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
    }
}
