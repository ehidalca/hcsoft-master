using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.Base
{
    public class RespuestaJS
    {
        private bool respuesta;
        private string mensaje;
        private object data;


        public bool Respuesta
        {
            get { return this.respuesta; }
            set { this.respuesta = value; }
        }

        public string Mensaje
        {
            get { return this.mensaje; }
            set { this.mensaje = value; }
        }

        public RespuestaJS(bool respuesta, string mensaje, object data)
        {
            this.respuesta = respuesta;
            this.mensaje = mensaje;
            this.data = data;

        }

    }
}
