using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.Base.Objetos
{
    public class ObjConfiguracion
    {
        private int id;
        private string nombre;
        private string valor;

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
        public string Valor
        {
            get { return this.valor; }
            set { this.valor = value; }
        
        }

        public ObjConfiguracion()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.valor = string.Empty;
        }
        public ObjConfiguracion(int id, string nombre, string valor)
        {
            this.id = id;
            this.nombre = nombre;
            this.valor = valor;
        
        }
        public ObjConfiguracion(System.Data.DataRow dr)
        {
            this.Id = Util.Formato.GetDato<int>(dr["id"].ToString());
            this.nombre = Util.Formato.GetDato<string>(dr["Nombre"].ToString());
            this.valor = Util.Formato.GetDato<string>(dr["Valor"].ToString());
        }
    }
}
