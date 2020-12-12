using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace HCSoft.Util
{
    public class Serializa
    {
        private bool respuesta;
        private string mensaje;


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
    }
}
