using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.POS.Objetos
{
    public class ObjFolios
    {
        private int id;
        private int caja_id;
        private int tipodocumento_id;
        private int folio_inicial;
        private int folio_termino;
        private int folio_siguiente;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int Caja_Id
        {
            get { return this.caja_id ; }
            set { this.caja_id = value; }
        }
        public int TipoDocumento_Id
        {
            get { return this.tipodocumento_id;  }
            set { this.tipodocumento_id = value; }

        }
        public int Folio_Inicial
        {
            get { return this.folio_inicial; }
            set { this.folio_inicial = value; }
        }
        public int Folio_Termino
        {
            get { return this.folio_termino;  }
            set { this.folio_termino = value; }
        }
        public int Folio_Siguiente
        {
            get { return this.folio_siguiente; }
            set { this.folio_siguiente = value; }
        }

        public ObjFolios(int id, int caja_id, int tipodocumento_id, int folio_inicial, int folio_termino, int folio_siguiente)
        {
            this.id = id;
            this.caja_id = caja_id;
            this.tipodocumento_id = tipodocumento_id;
            this.folio_inicial = folio_inicial;
            this.folio_termino = folio_termino;
            this.Folio_Siguiente = folio_siguiente;
        }


        public ObjFolios(System.Data.DataRow dr)
        {

            this.id = Util.Formato.GetDato<int>(dr["id"]);
            this.caja_id = Util.Formato.GetDato<int>(dr["caja_id"]);
            this.tipodocumento_id  = Util.Formato.GetDato<int>(dr["tipo_documento_id"]);
            this.folio_inicial = Util.Formato.GetDato<int>(dr["folio_inicial"]);
            this.folio_termino = Util.Formato.GetDato<int>(dr["folio_termino"]);


        }

    }
}
