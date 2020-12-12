using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.Base.Objetos
{
   public class ObjComercio
    {
        private string email;
        private string password;
        private int tipoComercioId;

        public ObjComercio()
        {
            this.email = "";
            this.password = "";
            this.tipoComercioId = 0;
        }
        public ObjComercio(string email, string password, int tipoComercioId)
        {
            this.email = email;
            this.password = password;
            this.tipoComercioId = tipoComercioId;
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public int TipoComercioId
        {
            get { return this.tipoComercioId; }
            set { this.tipoComercioId = value; }
        }
       

    }
}
