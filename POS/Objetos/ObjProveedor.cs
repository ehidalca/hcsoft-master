using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;

namespace HCSoft.POS.Objetos
{
   public class ObjProveedor
    {
       private int id;
       private string nombre;
       private string direccion;
       private string telefono;

       public int Id
       {
           get { return this.id ;}
           set { this.id = value; }
       }
       public string Nombre
       {
           get { return this.nombre; }
           set { this.nombre = value; }
       
       }
       public string Direccion 
       {
           get { return this.nombre; }
           set { this.nombre = value; }
       
       }
       public string Telefono
       {
           get { return this.telefono; }
           set { this.telefono = value; }
       
       }

       public ObjProveedor()
       {
           this.id = 0;
           this.nombre = string.Empty;
           this.telefono = string.Empty;
           this.direccion = string.Empty;
       }
       public ObjProveedor(int id, string nombre, string telefono, string direccion)
       {

           this.id = id;
           this.nombre = nombre;
           this.telefono = telefono;
           this.direccion = direccion;

       }
       public ObjProveedor(System.Data.DataRow  dr)
       {
           this.id = Util.Formato.GetDato<int>(dr["Id"].ToString());
           this.nombre = Util.Formato.GetDato<string>(dr["Nombre"].ToString());
           this.direccion = Util.Formato.GetDato<string>(dr["direccion"].ToString());
           this.telefono = Util.Formato.GetDato<string>(dr["telefono"].ToString());

       }
    }
}
