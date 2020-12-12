using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;


namespace AppPOS
{
  public class Cajas
    {

        
        public DataTable Listar()
        {
            try
            {
                return new MyCon().EjecutaConsulta("SELECT * FROM cajas");
            }
            catch (Exception)
            {

                throw;
            }
            


        }

     

     

       
    }
}
