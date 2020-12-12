using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HCSoft.POS.Objetos
{
    public  class ObjVenta
    {
        private DateTime fecha;
        private int tipodocumento_id;
        private Int32 folio;
        private int idusuario;
        private int idcaja;
        private double total;
        private List<ObjItemCaja> productos;
        public ObjVenta(DateTime fecha, int idcaja, int idusuario, double total, List<ObjItemCaja> productos, int folio, int tipodocumento_id)
        {
            this.fecha = fecha;
            this.idcaja= idcaja;
            this.idusuario = idusuario;
            this.total = total;
            this.productos = productos;
            this.folio = folio;
            this.tipodocumento_id = tipodocumento_id;
        }
        public DateTime Fecha
        {
            get { return this.fecha;  }
            set { this.fecha = value; }
        }
        public Int32 Folio
        {
            get { return this.folio; }
            set { this.folio = value; }
        }
        public int IdUsuario
        {
            get { return this.idusuario; }
            set { this.idusuario = value; }
        }
        public int IdCaja
        {
            get { return this.idcaja; }
            set { this.idcaja = value; }
        }
        public Double Total
        {
            get { return this.total; }
            set { this.total = value; }
        }
        public int Tipodocumento_id
        {
           get { return this.tipodocumento_id; }
           set { this.tipodocumento_id = value; }
        }
        public List<ObjItemCaja> Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }

        public ObjVenta(DataRow dr)
        {
            
        }

    }



}
