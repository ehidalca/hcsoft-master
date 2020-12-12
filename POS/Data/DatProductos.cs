using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;
using HCSoft.POS.Objetos;
using System.Data;

namespace HCSoft.POS.Data
{
   public class DatProductos
    {
        private string nombretabla = "productos";
       public List<ObjProducto> Listar()
       {
          List<ObjProducto> productos = new List<ObjProducto>();
          string query = "SELECT * FROM pos_productos";
          DataTable dt = new ConexionMy().EjecutaConsultaDt(query);

          if (dt.Rows.Count !=0 )
          {
             foreach(DataRow dr in dt.Rows)
             {
                 ObjProducto producto = new ObjProducto(dr);
                 productos.Add(producto);
             }

          }

          return productos;
       
       }

       public List<ObjProducto> ListarPorCategoria(int idcategoria)
       {
           List<ObjProducto> productos = new List<ObjProducto>();
           string query = "SELECT * FROM " + nombretabla +" where categoria_id='" +  idcategoria +"'";
           DataTable dt = new ConexionMy().EjecutaConsultaDt(query);

           if (dt.Rows.Count != 0)
           {
               foreach (DataRow dr in dt.Rows)
               {
                   ObjProducto producto = new ObjProducto(dr);
                   productos.Add(producto);
               }

           }

           return productos;

       }

       public List<ObjProducto> Buscar(string descripcion, string codigo)
       {
           List<ObjProducto> productos = new List<ObjProducto>();
           string query = "SELECT * FROM "+ nombretabla +" WHERE NOMBRE LIKE'%"+ descripcion+" %'";
           DataTable dt = new ConexionMy().EjecutaConsultaDt(query);

           if (dt.Rows.Count != 0)
           {
               foreach (DataRow dr in dt.Rows)
               {
                   ObjProducto producto = new ObjProducto(dr);
                   productos.Add(producto);
               }

           }

           return productos;

       }

       public bool AsociaCategorias(string codigoproducto ,List< ObjCategoria> categorias )
       {
           int idproducto = TraerPorCodigo(codigoproducto).Id;
           bool retorno = false;

          foreach(ObjCategoria categoria in categorias)
          {
              int id = 0;
              id = new ConexionMy().EjecutaConsulta("INSERT INTO NAV_CATEGORIAPRODUCTOS(Idcategoria, IdProducto) values('" + categoria.Id +"','" + idproducto+"')");

              if (id != 0) { retorno = true; }
          }


          return retorno;
       
       }

       public ObjProducto TraerPorCodigo(string codigo)
       {
           ObjProducto producto = new ObjProducto();
           DataTable dt = new ConexionMy().EjecutaConsultaDt("SELECT * FROM "+ nombretabla +" WHERE CODIGO='" + codigo + "'");
           if(dt.Rows.Count !=0)
           {
               producto = new ObjProducto(dt.Rows[0]);
                
           }

            return producto; 
       
       }

       public DataTable TraerPorId(int idproducto)
        {
            try
            {
                string query = "SELECT * FROM " + nombretabla + " where  id = " + idproducto + "";
                return new ConexionMy().EjecutaConsultaDt(query);
            }
            catch (Exception)
            {

                throw;
            }

        }

       public int Ingresar(ObjProducto producto)
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaId("INSERT INTO PRODUCTOS(codigo, nombre, imagen, valor)" +
                            "VALUES('"+ producto.Codigo +"','"+ producto.Nombre +"', '"+ producto.Imagen +"', '"+ producto.ValorVenta +"')" );
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
