using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;
using HCSoft.POS.Objetos;
using System.Data;
namespace HCSoft.POS.Data
{
    public class DatBodegas
    {
        public List<ObjBodega> ListadoBodegasporSede(int idsede)
        {
            List<ObjBodega> listadobodegas = new List<ObjBodega>();
            string query = "SELECT * FROM  bodegas WHERE IDSEDE=" + idsede.ToString() +"";
            DataTable dt = new ConexionMy().EjecutaConsultaDt(query);
            foreach(DataRow  dr  in dt.Rows)
            {
                 ObjBodega objbodega = new ObjBodega(dr);
                 listadobodegas.Add(objbodega);
            }

            return listadobodegas;
        
        }

        public DataTable Listar()
        {
            try
            {
                return new ConexionMy().EjecutaConsultaDt("SELECT  * FROM bodegas where estado=1");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable Get(string nombre)
        {
            try
            {
                return new ConexionMy().EjecutaConsultaDt("SELECT  * FROM bodegas where nombre='"+nombre +"'");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int Ingresar(ObjBodega bodega)
        {
            try
            {
                        
               return new HCSoft.Util.ConexionMy().EjecutaConsulta("INSERT INTO bodegas(nombre, sucursalId) VALUES('" + bodega.Nombre + "', " + bodega.IdSede + ")");
                     
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
