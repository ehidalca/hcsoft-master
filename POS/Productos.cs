using System;
using System.Collections.Generic;
using HCSoft.POS.Objetos;
using HCSoft.Util;
using System.Data;
using MySql.Data.MySqlClient;

namespace HCSoft.POS
{
    public class Productos
    {

        private int usuarioId;

        public Productos()
        { }
        public Productos(int usuarioId)
        {
            this.usuarioId = usuarioId;
        }

        public DataTable Listar()
        {
            try
            {   
                
                string query = "SELECT * FROM productos";
                return new MyCon().EjecutaConsulta(query);

            }
            catch (Exception)
            {

                throw;
            }
           

         

        }

        public DataTable ListarPorCategoria(int categoriaId)
        {
            try
            {
                string query = "SELECT * FROM products WHERE categoria_id=@categoria_id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("categoria_id",categoriaId),
                };
                return new MyCon().EjecutaConsulta(query, parametros);
            }
            catch (Exception)
            {

                throw;
            }
            
           


        }

        public DataTable Buscar(string descripcion)
        {
            try
            {
                string query = "SELECT * FROM productos WHERE nombre LIKE  %@descripcion% ";
                MySqlParameter[] parametros = {
                    new MySqlParameter("descripcion",descripcion),
                };
                return new MyCon().EjecutaConsulta(query, parametros);
  
            }
            catch (Exception)
            {

                throw;
            }

        }
    /*
        public bool AsociaCategorias(string codigoproducto, List<ObjCategoria> categorias)
        {
            int idproducto = TraerPorCodigo(codigoproducto).Id;
            bool retorno = false;

            foreach (ObjCategoria categoria in categorias)
            {
                int id = 0;
                id = new ConexionMy().EjecutaConsulta("INSERT INTO NAV_CATEGORIAPRODUCTOS(Idcategoria, IdProducto) values('" + categoria.Id + "','" + idproducto + "')");

                if (id != 0) { retorno = true; }
            }


            return retorno;

        }*/
        public DataTable ConsultarPorCodigo(string codigo)
        {
            try
            {
                string query = "SELECT * FROM  productos  WHERE  codigo = @codigo";
                MySqlParameter[] parametros = {
                                    new MySqlParameter("codigo",codigo)
                                };

                return new MyCon().EjecutaConsulta(query, parametros);


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
                string query = "SELECT * FROM  productos  WHERE  id = @id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id",id)
                };

                return new MyCon().EjecutaConsulta(query, parametros);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Crear(string codigo, string nombre, string descripcion, string imagen, int categoriaId, int unidadMedidaId , int valor)
        {
            try
            {
                DateTime fechHoraCreacion = DateTime.Now;
                string query = "INSERT INTO productos(codigo,nombre,imagen,categoria_id, valor, unidad_medida_id, fecha_hora_creacion, usuario_creacion_id) VALUES(@codigo,@nombre,@imagen,@categoria_id,@valor,@unidadMedidaId,@fecha_hora_creacion,@usuario_creacion_id)";
                MySqlParameter[] parametros = {
                    new MySqlParameter("codigo",codigo),
                    new MySqlParameter("nombre", nombre),
                    new MySqlParameter("descripción", descripcion),
                    new MySqlParameter("imagen", imagen),
                    new MySqlParameter("categoria_id", categoriaId),
                    new MySqlParameter("valor", valor),
                    new MySqlParameter("unidadMedidaId", unidadMedidaId),
                    new MySqlParameter("fecha_hora_creacion", fechHoraCreacion),
                    new MySqlParameter("usuario_creacion_id", this.usuarioId)

                };

                return new MyCon().EjecutaQuery(query, parametros);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Actualizar(int id, string codigo, string nombre, string imagen, int categoriaId, int usuarioId)
        {
            try
            {
                DateTime fechHoraActualizacion = DateTime.Now;
                string query = "UPDATE productos SET codigo=@codigo, nombre=@nombre, imagen=@imagen, categoria_id=@categoria_id, fecha_hora_actualizacion=@fecha_hora_actualizacion, usuario_actualizacion_id=@usuario_actualizacion_id WHERE id=@id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id",id),
                    new MySqlParameter("codigo",codigo),
                    new MySqlParameter("nombre", nombre),
                    new MySqlParameter("imagen", imagen),
                    new MySqlParameter("categoria_id", categoriaId),
                    new MySqlParameter("fecha_hora_actualizacion", fechHoraActualizacion),
                    new MySqlParameter("usuario_actualizacion_id", usuarioId)

                };

                return new MyCon().EjecutaQuery(query, parametros);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Eliminar(int id, int usuarioId)
        {
            try
            {
                DateTime fechHoraEliminacion = DateTime.Now;
                string query = "UPDATE productos SET eliminado=1, fecha_hora_eliminacion=@fecha_hora_eliminacion, usuario_eliminacion_id=@usuario_eliminacion_id where id=@id";
                MySqlParameter[] parametros = {
                    new MySqlParameter("id", id),
                    new MySqlParameter("fecha_hora_eliminacion", fechHoraEliminacion),
                    new MySqlParameter("usuario_eliminacion_id", usuarioId)
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
