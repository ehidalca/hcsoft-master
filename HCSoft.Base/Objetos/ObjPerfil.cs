using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;


namespace HCSoft.Base.Objetos
{
   public class ObjPerfil
    {
       private int id =0;
       private string nombre;

       public ObjPerfil(DataRow  dr)
       { 
       this.id= Formato.GetDato<int>(dr["IdPerfil"]);
       this.nombre =  Formato.GetDato<string>( dr["Nombre"] );
 
       }
       public ObjPerfil()
       {
           this.id = 0;
           this.nombre = string.Empty;
       
       }

       public string Nombre
         {

             get { return this.nombre; }
             set { this.nombre = value; }
       }

       public int Id
       {
           get { return this.id; }
           set { this.id = value; }
       }

    }
}
