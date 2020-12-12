using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using HCSoft.POS.Objetos;
using HCSoft.Util;
using MySql.Data.MySqlClient;

namespace HCSoft.POS
{
    public class Cajas
    {
        private int usuarioId;
        public Cajas()
        { 
            
        }

        public Cajas(int id)
        {
            this.usuarioId = id;
        }

        public DataTable Listar()
        {
            try
            {
                string query = "select cajas.*, sucursales.nombre as sucursal from cajas inner join sucursales on  cajas.sucursal_id =  sucursales.id";
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
                string query = "SELECT cajas.*, sucursales.nombre as sucursal from cajas inner join sucursales on  cajas.sucursal_id =  sucursales.id WHERE cajas.id =@id ";
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

        public bool Crear(string nombre,int  sucursalId)
        {
            try
            {
                DateTime fechaHoraCreacion = DateTime.Now;
                string query = "INSERT INTO cajas(nombre,sucursal_id, fecha_hora_creacion, usuario_creacion_id) VALUES(@nombre,@sucursal_id,@fecha_hora_creacion, @usuario_creacion_id)";
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

        public bool Actualizar(int id, string nombre, int sucursalId )
        {
           try
            {
                DateTime fechaHoraCreacion = DateTime.Now;
                string query = "UPDATE cajas SET nombre=@nombre, sucursal_id=@sucursalId, fecha_hora_creacion=@fecha_hora_creación , usuario_creacion_id=@usuario_creacion_id WHERE id=@id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id",id),
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

        public bool Eliminar(int id)
        {
            try
            {
                DateTime fechaHoraCreacion = DateTime.Now;
                string query = "UPDATE cajas SET eliminado=1 WHERE id=@id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id",id)
    
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
