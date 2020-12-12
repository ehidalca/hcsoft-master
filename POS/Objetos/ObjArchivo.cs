using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HCSoft.POS.Objetos
{
   public class ObjArchivo
    {
       private string archivo;
       private string tipo;
       private string nombre;
       private string ruta;

       public string Archivo
       { 
         get {return this.archivo;}
         set {this.archivo= value;}
       }

       public string Tipo 
       {
           get { return this.tipo ; }
           set { this.tipo = value; }
       }
       public string Nombre
       {
           get { return this.nombre; }
           set { this.nombre = value; }
       
       }
       public string Ruta
       {
           get { return this.ruta; }
           set { this.ruta = value; }
       }

       public ObjArchivo(string filename)
       {

           this.Archivo = Path.GetFileName(filename);
           this.Tipo = Path.GetExtension(filename);
           this.Ruta = Path.GetFullPath(filename);
           this.Nombre = Path.GetFileNameWithoutExtension(filename);
       }
    }
}
