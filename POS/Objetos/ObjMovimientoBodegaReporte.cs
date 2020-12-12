using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;

namespace HCSoft.POS.Objetos
{
    public class ObjMovimientoBodegaReporte
    {
        private int id;
        private DateTime fecha;
        private TimeSpan hora;
        private int idproducto;
        private int idtipomovimiento;
        private int cantidad;
        private int idorigen;
        private int iddestino;
        private string nombreproducto;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public TimeSpan Hora
        {
            get { return this.hora; }
            set { this.hora = value; }
        
        }

        public int IdProducto
        {
            get { return this.idproducto; }
            set { this.idproducto = value; }
        
        }

        public int IdTipoMovimiento
        {
            get { return this.idtipomovimiento; }
            set { this.idtipomovimiento = value; }
        }
        
        public int Cantidad
        {
            get { return this.cantidad;  }
            set { this.cantidad = value; }

        }

        public int IdOrigen
        {
            get { return this.idorigen; }
            set { this.idorigen = value; }
        }

        public int IdDestino
        {
            get { return this.iddestino; }
            set { this.iddestino = value; }
        }


        public string NombreProducto
        {
           get { return this.nombreproducto;  }
            set { this.nombreproducto = value; }
        }

        public ObjMovimientoBodegaReporte(int id, DateTime fecha, TimeSpan hora, int idproducto, ObjTipoMovimiento tipomovimiento, int cantidad, int idorigen, int iddestino)
        {
            this.id = id;
            this.fecha = fecha;
            this.hora = hora;
            this.idproducto = idproducto;
            this.idtipomovimiento = tipomovimiento.Id;
            this.cantidad = cantidad;
            this.idorigen = idorigen;
            this.iddestino = iddestino;
    
        }

      public  ObjMovimientoBodegaReporte(DataRow dr)
        {
            this.id = Util.Formato.GetDato<int>(dr["id"]);
            this.fecha= Util.Formato.GetDato<DateTime>(dr["fechahora"]);
            this.idproducto = Util.Formato.GetDato<int>(dr["idproducto"]);
            this.nombreproducto = Util.Formato.GetDato<string>(dr["nombreproducto"]);
            this.cantidad = Util.Formato.GetDato<int>(dr["cantidad"]);


        }
    }
}
