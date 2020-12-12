using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;

namespace HCSoft.POS.Objetos
{
   public class ObjProducto
    {

       private int id;
       private string codigo;
       private string nombre;
       public string Descripcion;
       private string imagen;
       private int valorventa;
       public int costo;
       public int Idcategoria;


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
       public string Imagen
       {
           get { return this.imagen; }
           set { this.imagen = value; }
       }
       public int ValorVenta
       {
           get { return this.valorventa; }
           set { this.valorventa = value; }
       }

        public int Costo
        {
            get { return this.costo; }
            set { this.costo = value; }
        }

       public ObjProducto()
       {
           this.id = 0;
           this.codigo = string.Empty;
           this.nombre = string.Empty;
           this.valorventa = 0;
          
       }

      
       public ObjProducto(int id, string codigo, string nombre, string descripcion, string imagen, int valorventa, int costo, int idcategoria)
       {
           this.id = id;
           this.codigo = codigo;
           this.nombre = nombre;
           this.Descripcion = descripcion;
           this.imagen = imagen;
           this.valorventa = valorventa;
           this.Idcategoria = idcategoria;
      }

       public ObjProducto(DataRow dr)
       {
           this.id = Util.Formato.GetDato<int>(dr["id"].ToString());
           this.codigo = Util.Formato.GetDato<string>(dr["Codigo"].ToString());
           this.nombre = Util.Formato.GetDato<string>(dr["nombre"].ToString());
           this.imagen = Util.Formato.GetDato<string>(dr["imagen"].ToString());
           this.Costo = Util.Formato.GetDato<int>(dr["costo"].ToString());
           this.valorventa = Util.Formato.GetDato<int>(dr["valor"].ToString());
       }
    }
}
