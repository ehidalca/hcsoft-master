using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HCSoft.POS.Objetos
{
    public class ObjTotales
    {
        private long totalfinal;
        private long totalneto;
        private long totaliva;
       

        public long TotalFinal
        {
            get { return this.totalfinal; }
            set { this.totalfinal = value; }
        }
        public long TotalNeto
        {
            get { return this.totalneto; }
            set { this.totalneto = value; }
        }
        public long TotalIva
        {
            get { return this.totaliva; }
            set { this.totaliva = value; }

        }

        public ObjTotales(List<ObjItemCaja> itemscaja)
        {
            
            
            foreach (ObjItemCaja  item in itemscaja)
            {
                this.totalfinal = totalfinal + (item.Producto.ValorVenta * item.Cantidadlinea );
           
            }

     
            this.totalneto = this.TotalFinal - TotalIva;
        
        }
    }
}
