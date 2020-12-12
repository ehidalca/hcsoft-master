using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.POS.Objetos
{
   public class ObjItemCaja
    {

       private int id;
       private int numerodelinea;
       private int cantidadlinea;
       private ObjProducto producto;
       private int preciolinea;


       public int NumerodeLinea
       {
           get { return this.numerodelinea; }
           set { this.numerodelinea = value; }
       
       }
       public int Cantidadlinea
       {
           get { return this.cantidadlinea; }
           set { this.cantidadlinea = value; }
       }
       public ObjProducto Producto { get { return this.producto; } set { this.producto = value; } }
       public ObjItemCaja( ObjProducto producto, int numerodelinea, int cantidad)
       {
           this.id = producto.Id;
           this.numerodelinea = numerodelinea;
           this.producto = producto;
           this.cantidadlinea = cantidad;
          
       }

       public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

       public string Nombre { get { return this.producto.Nombre; }}

       public string Codigo { get { return this.producto.Codigo; } }

       public string PrecioUnitario { get { return this.producto.ValorVenta.ToString("N0"); } }

       public int PrecioLinea
        {
            get { return this.preciolinea; }
            set { this.preciolinea = value; }
        }

        public ObjItemCaja()
       { }
      
    }
}
