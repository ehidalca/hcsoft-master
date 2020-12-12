using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.POS.Objetos
{
     public  class ObjGenerico
    {

         private int id;
         private string codigo;
         private string descripcion;

         public int Id
         { 
            get{return this.id; }
             set { this.id = value; }
         }

         public string Codigo
         {
             get { return this.codigo; }
             set {this.codigo=value;}
         }

         public string Descripcion
         {
             get { return this.descripcion ; }
             set { this.descripcion = value; }


         }


     }

  
}
