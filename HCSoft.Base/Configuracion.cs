using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Base.Data;

namespace HCSoft.Base
{
   public class Configuracion
    {

       public string ObtieneRutaImagenes()
       {

           try
           {
               return new DatConfiguracion().TraerPorNombre("PATHIMAGEN").Valor;
           }

           catch (Exception)
           {
               
               throw;
           }
       
       }

       public string ObtieneImagenDefecto()
       {
           try
           {
               return new DatConfiguracion().TraerPorNombre("IMAGENDEFECTO").Valor;
           }
           catch (Exception)
           {
               
               throw;
           }
       
       }

       public int ObtienePorcentajeIva()
       {

           try
           {
               return Int32.Parse(new Data.DatConfiguracion().TraerPorNombre("IVA").Valor);
           }
           catch (Exception)
           {

               throw;
           }
       }

      

    }
}
