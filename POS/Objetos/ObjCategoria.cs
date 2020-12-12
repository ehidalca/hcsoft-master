using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.POS.Objetos
{
    public class ObjCategoria
    {

        private int id;
        private string nombre;
        private string descripcion;
        private string imagen;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public string Imagen
        {
            get { return this.imagen; }
            set { this.imagen = value; }
        }

        public ObjCategoria(int  id, string nombre, string descripcion, string imagen)
        {
            this.id=id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.imagen = imagen;    
        }

        public ObjCategoria(DataRow dr)
        {
            this.id = Int32.Parse(dr["Id"].ToString());
            this.nombre = dr["Nombre"].ToString();
           // this.descripcion = dr["Descripcion"].ToString();
            this.imagen = dr["imagen"].ToString();
        }


        public ObjCategoria()
        {

            this.id = 0;
            this.nombre = string.Empty;
            // this.descripcion = dr["Descripcion"].ToString();
            this.imagen = string.Empty;
        
        
        }


         




        
    }
}
