using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HCSoft.Base.Objetos
{
   public class ObjItemMenu
    {
        private int id;
        private string nombre;
        private string url;
        private int idpadre;
        private int menuprincipal;

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
        public string  Url
        {
            get { return this.url;  }
            set { this.url = value; }
        }
        public int IdPadre
        {
            get { return this.idpadre; }
            set { this.idpadre = value; }

        }
        public int MenuPrincipal
        {
            get { return this.menuprincipal; }
            set { this.menuprincipal = value; }
        }

        public ObjItemMenu(DataRow dr )
        {
            this.id = Util.Formato.GetDato<int>(dr["id"]);
            this.nombre = Util.Formato.GetDato<string>(dr["nombre"]);
            this.url = Util.Formato.GetDato<string>(dr["url"]);
            this.idpadre = Util.Formato.GetDato<int>(dr["idpadre"]);
            this.menuprincipal = Util.Formato.GetDato<int>(dr["menuprincipal"]);
        }

    }
}
