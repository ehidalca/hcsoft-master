using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.POS.Data;
using HCSoft.POS.Objetos;

namespace HCSoft.POS.Negocio
{
   public class CategoriaServicio
    {

       public List<ObjCategoriaServicio> Listar(long idempresa)
       {
           try
           {
               return new DatCategoriaServicio().Listar(idempresa);
           }
           catch (Exception)
           {
               
               throw;
           }
       
       }
    }
}
