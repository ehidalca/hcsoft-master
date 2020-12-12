using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HCSoft;

namespace HCSoft.Base.Objetos
{
      public class ObjUsuario
    {

          private int id;
          private string nombre;
          private string email;
          private string password;
          private string nombreusuario;
          private bool estado;
          private int cliente_id;
       

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

          public string NombreUsuario 
          {
              get { return this.nombreusuario; }
              set { this.nombreusuario = value; }
          }

          public bool Estado
          {
              get { return this.estado; }
              set { this.estado = value; }
          
          }

          public int Cliente_Id
            {
               get { return this.cliente_id; }
               set { this.cliente_id = value; }
             }

          public ObjUsuario()
          {}

          public ObjUsuario(int id, string nombre, string email, string password)
          {
              this.Id = id;
              this.Nombre = nombre;
              this.Email = email;
              this.Password = password;
          }

          public ObjUsuario(DataRow dr)
        {
            this.Id =  Util.Formato.GetDato<int>( dr["id"]);
            this.Nombre =Util.Formato.GetDato<string>(dr["nombre"]);
            this.Email =Util.Formato.GetDato<string>(dr["email"].ToString());
            this.nombreusuario =Util.Formato.GetDato<string>(dr["usuario"].ToString());
            this.estado =Util.Formato.GetDato<bool>(dr["activo"].ToString());
            this.password =Util.Formato.GetDato<string>(dr["password"].ToString());
            this.cliente_id = Util.Formato.GetDato<int>(dr["cliente_id"].ToString());


        }
    }
}
