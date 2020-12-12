using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.Base.Objetos
{
   public class ObjAcceso
    {
        public bool acceso { get; set; }
        public string usuario { get; set; }
        public int IdUsuario;
        public int Cliente_Id { get; set; }
        public List<ObjRol> roles { get; set; }

        public string urldefecto;

        public int idusuario
         {
            get { return this.IdUsuario; }
            set { this.IdUsuario = value; }
        }

        public string  UrlDefecto
            {
            get { return this.urldefecto; }
            set { this.urldefecto = value; }
        }


    }
}
