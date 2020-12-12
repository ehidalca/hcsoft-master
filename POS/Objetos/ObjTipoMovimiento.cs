using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;

namespace HCSoft.POS.Objetos
{
  
   public class ObjTipoMovimiento
    {
       private int id;
       private string codigo;
       private string nombre;
       
       public int Id
       {
           get { return this.id; }
           set { this.id = value; }
       }

       public string Codigo
       {
           get { return this.codigo; }
           set { this.codigo = value; }
       }

       public string Nombre
       {
           get { return this.nombre; }
           set { this.nombre = value; }
       }

       public ObjTipoMovimiento()
       { }
       public ObjTipoMovimiento(DataRow dr)
       {
           this.id = Util.Formato.GetDato<int>(dr["id"].ToString());
           //this.codigo = Util.Formato.GetDato<string>(dr["Codigo"].ToString());
           this.nombre = Util.Formato.GetDato<string>(dr["nombre"].ToString());
       }

        public ObjTipoMovimiento(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

    }
}
