using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;

namespace HCSoft.POS.Objetos
{
   public class  ObjCaja
    {
      private int id;
      private string nombre;
      private int sucursalId;

      public int Id
      {
          get { return this.id; }
          set { this.id = value; }
      }
      public string Nombre
      {
          get { return this.nombre;}
          set { this.nombre = value; }
      }
      public int SucursalId
        { get { return this.sucursalId; }
            set { this.sucursalId = value; }
        }
      public ObjCaja(DataRow dr)
      {
          this.id = Util.Formato.GetDato<int>(dr["Id"].ToString());
          this.nombre = Util.Formato.GetDato<string>(dr["Nombre"].ToString());
      }
      public ObjCaja()
      { 
      
      
      }

    }
}
