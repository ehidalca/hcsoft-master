using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.POS.Data;
using HCSoft.POS.Objetos;

namespace HCSoft.POS.Negocio
{
   public class Servicios
    {
       public List<ObjServicio> Listar()
       {
           try
           {
               return new Data.DatServicios().Listar();
           }
           catch (Exception)
           {
               
               throw;
           }
       }
    }
}
