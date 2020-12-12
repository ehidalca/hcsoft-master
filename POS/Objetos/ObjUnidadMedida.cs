using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.POS.Objetos
{
   public class ObjUnidadMedida
    {
        private int id;
        private string nombre;
        private bool estado;

        public ObjUnidadMedida()
        {
            this.id = 0;
            this.nombre = "";
            this.estado = false;
        }

        public ObjUnidadMedida(int id, string nombre, bool estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.estado = estado;

        }

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

        public bool Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
    }
}
