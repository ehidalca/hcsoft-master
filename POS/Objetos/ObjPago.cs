using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.POS.Objetos
{
    public class ObjPago
    {
        public int idmediopago;
        public int monto;

        public int IdMedioPago
        {
            get { return this.idmediopago;  }
            set { this.idmediopago = value; }
        }
        public int Monto
        {
            get { return this.monto; }
           set { this.monto = value; }
        }
        ObjPago(int idmediopago, int monto)
        {
            this.idmediopago = IdMedioPago;
            this.monto = monto;
        }
    }
}
