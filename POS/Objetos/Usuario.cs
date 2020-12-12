using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HCSoft.Util;

namespace HCSoft.POS.Objetos
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string email;
        private string clave;
        private string imagen;
        private string fechaHoraCreacion;
        private int comercioId;
        private bool activo;
        
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Email {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Clave
        {
            get  { return this.clave; }
            set { this.clave = value; }
        }

        public string Imagen
        {
            get { return this.imagen; }
            set { this.imagen = value; }
        }

        public string FechaHoraCreacion
        {
            get { return this.fechaHoraCreacion; }
            set { this.fechaHoraCreacion = value; }
        }

        public int ComercioId
        {
            get { return this.comercioId; }
            set { this.comercioId = value; }
        }

        public bool Activo {
            get { return this.activo; }
            set { this.activo = value; }
        }

        public Usuario()
        {
            this.id = 0;
            this.nombre = "";
            this.email = "";
            this.clave = "";
            this.imagen = "";
            this.fechaHoraCreacion = "";
            this.comercioId = 0;
            this.activo = true;
        }

        public Usuario(DataRow dr)
        {
            this.id = Util.Formato.GetDato<int>(dr["id"]);
            this.nombre = Util.Formato.GetDato<string>(dr["nombre"]);
            this.email = Util.Formato.GetDato<string>(dr["email"]);
            this.clave = Util.Formato.GetDato<string>(dr["clave"]);
            this.imagen = Util.Formato.GetDato<string>(dr["imagen"]);
            this.fechaHoraCreacion = Util.Formato.GetDato<string>(dr["fechaHoraCreacion"]);
            this.comercioId = Util.Formato.GetDato<int>(dr["comercioId"]);
            this.activo = Util.Formato.GetDato<bool>(dr["activo"]);

        }
    }
}
