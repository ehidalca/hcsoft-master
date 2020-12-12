using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft.Util;
namespace HCSoft.POS.Objetos
{
  public class ObjBodega
    {
      private int idsede;
      private int idbodega;
      private string codigo;
      private string nombre;
      public ObjBodega()
       {
         

        }
      public int IdSede
      {
          get { return this.idsede; }
          set { this.idsede = value; }
      }

      public int IdBodega
      {
          get { return this.idbodega; }
          set { this.idbodega = value; }
      }

      public string Codigo
      {
          get { return this.codigo; }
          set { this.codigo = value; }
      }

      public string Nombre
      {
          get { return this.nombre; }
          set { this.nombre = value; }
      }

       
      public ObjBodega(DataRow dr)
      {
          this.idsede =  Util.Formato.GetDato<int>(dr["IdSede"].ToString());
          this.idbodega = Util.Formato.GetDato<int>(dr["IdBodega"].ToString());
          this.codigo = Util.Formato.GetDato<string>(dr["Codigo"].ToString());
          this.nombre = Util.Formato.GetDato<string>(dr["Nombre"].ToString());

      }
    }
}
