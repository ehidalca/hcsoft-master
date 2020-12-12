using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;



namespace HCSoft.POS.Objetos
{
    public class ObjCategoriaServicio
    {
        private int id;
        private string nombre;

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

        public ObjCategoriaServicio(DataRow  dr)
        { 
            this.id = Util.Formato.GetDato<int>(dr["IdCategoriaServicio"].ToString());
            this.nombre = Util.Formato.GetDato<string>(dr["Nombre"].ToString());
        }
    }
}
