using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.Base.Objetos
{
     public class ObjRol
    {
        public int IdRol { get; set; }
        public string  nombre  { get; set; }

        public ObjRol()
        { 
        }

        public ObjRol(DataRow dr)
        {

            this.IdRol = Int32.Parse(dr["IdRol"].ToString());
            this.nombre = dr["Nombre"].ToString();
        
        }
    }
}
