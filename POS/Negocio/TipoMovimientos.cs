using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.POS.Data;
using HCSoft.POS.Objetos;
using System.Data;


namespace HCSoft.POS
{
   public class TipoMovimientos
    {
       public ObjTipoMovimiento TraerPorCodigo(string codigo)
       {

           try
           {
               return new DatTipoMovimientos().TraerPorCodigo(codigo);
           }
           catch (Exception)
           {
               
               throw;
           }
       
       
       }

        public DataTable ListarTipoMovimiento()
        {
            try
            {
                    List<ObjTipoMovimiento> listatipomovimientos = new List<ObjTipoMovimiento>();
                                string query = "SELECT *  FROM tipomovimientos ";
                                return new  HCSoft.Util.ConexionMy().EjecutaConsultaDt(query);
            }
            catch (Exception)
            {

                throw;
            }
            

           
        }

    }
}
