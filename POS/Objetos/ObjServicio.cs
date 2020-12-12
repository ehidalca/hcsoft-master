using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;

namespace HCSoft.POS.Objetos
{
   public class ObjServicio
    {
       private int id;
       private int idcategoria;
       private string nombre;
       private int minutos;
       private int precio;
       private string color;

       public int Id
       {
           get { return this.id; }
           set { this.id = value; }
       
       }

       public int IdCategoria
       {
           get { return this.idcategoria; }
           set { this.idcategoria = value; }
       
       }

       public string Nombre
       {
           get { return this.nombre; }
           set { this.nombre = value; }
       }

       public int Minutos
       {
           get { return this.minutos; }
           set { this.minutos = value; }
       
       }

       public int Precio
       {
           get { return this.precio; }
           set { this.precio = value; }
       }

       public string Color
       {
           get { return this.color; }
           set { this.color = value; }

       }

       public ObjServicio(DataRow dr)
       {
           this.id = Util.Formato.GetDato<int>(dr["IdServicio"]);
           this.idcategoria = Util.Formato.GetDato<int>(dr["IdCategoria"]);
           this.nombre = Util.Formato.GetDato<string>(dr["Nombre"]);
           this.minutos = Util.Formato.GetDato<int>(dr["Minutos"]);
           this.precio = Util.Formato.GetDato<int>(dr["Precio"]);
           this.color = Util.Formato.GetDato<string>(dr["Color"]);
         
         
       
       
       }
    }
}
