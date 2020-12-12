using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft;

namespace HCSoft.POS.Objetos
{
   public class ObjPersonal
    {
       private int id;
       private string rut;
       private string nombre;
       private string email;
       private string telefono;
       private string codigo;
       private string color;
       private string imagen;
       private string dias_bloqueados;

       public int Id
       {
           get { return this.id; }
           set { this.id = value; }       
       }

       public string Rut
       {
           get { return this.rut; }
           set { this.rut = value; }
       }

       public string Nombre
       {
           get { return this.nombre; }
           set { this.nombre = value; }
       }
       
       public string Email
       {
           get { return this.email; }
           set { this.email = value; }
       
       }

       public string Telefono
       {
           get { return this.telefono; }
           set { this.telefono = value; }
       }

       public string Codigo
       {
           get { return this.codigo; }
           set { this.codigo = value; }
       
       }

       public string Color
       {
           get { return this.color; }
           set { this.color = value; }
       
       }

       public string Imagen
       {

           get { return this.imagen;}
           set { this.imagen = value; }
       
       }

       public string DiasBloqueados
       {
           get { return this.dias_bloqueados; }
           set { this.dias_bloqueados = value; }
       
       }

       public ObjPersonal(DataRow dr)
       {
           this.id  = Util.Formato.GetDato<int>(dr["IdPersonal"]);
           this.rut = Util.Formato.GetDato<string>(dr["Rut"]);
           this.nombre = Util.Formato.GetDato<string>(dr["Nombre"]);
           this.email = Util.Formato.GetDato<string>(dr["Email"]);
           this.telefono = Util.Formato.GetDato<string>(dr["Telefono"]);
           this.codigo = Util.Formato.GetDato<string>(dr["Codigo"]);
           this.color = Util.Formato.GetDato<string>(dr["Imagen"]);
           this.dias_bloqueados = Util.Formato.GetDato<string>(dr["Dias_Bloqueados"]);
       
       }


    }
}
