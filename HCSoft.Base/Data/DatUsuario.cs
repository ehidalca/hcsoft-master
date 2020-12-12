using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;
using HCSoft.Base.Objetos;
using System.Data;


namespace HCSoft.Base.Data
{
     public class DatUsuario
    {
        private string nombretabla = "usuarios";
        private int cliente_id= 0;

        public DatUsuario(int cliente_id)
        {
            this.cliente_id = cliente_id;
        }

        public DataTable SELECT()
        {

            try
            {
                return new ConexionMy().EjecutaConsultaDt("select * from " + nombretabla +" WHERE cliente_id="+ this.cliente_id );

            }
            catch (Exception)
            {

                throw;
            }
        }

        public ObjUsuario Login(string nombreusuario, string password)
        {
            ObjUsuario usuario = new ObjUsuario();
            DataTable dt = new  ConexionMy().EjecutaConsultaDt("select * from usuarios where email='"+ nombreusuario +"' and password='"+ password +"'");
            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                usuario = new ObjUsuario(dr);

            }

            return usuario;
            
        
        }

   
        
        public bool ActualizaPassword(string email, string password)
        {


            int id = 
            id = new ConexionMy().EjecutaConsulta("UPDATE  TBL_USUARIOS SET PASSWORD ='"+password +"' WHERE EMAIL='" + email + "'");


            if (id != 0)
            { return true; }
            else
            { return false; }


        }

        public bool VerificaExistencia(string email)
        {
          DataTable   dt = new ConexionMy().EjecutaConsultaDt("SELECT * FROM USUARIOS WHERE EMAIL ='" + email + "'");
         
            if (dt.Rows.Count !=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ObjUsuario Trae(int idusuario) 
        {
            
            string query="SELECT  * FROM "+ nombretabla +" WHERE id='"+ idusuario+"'";
            DataTable dt = new  Util.ConexionMy().EjecutaConsultaDt(query);
            DataRow dr= dt.Rows[0];
            ObjUsuario usuario = new  ObjUsuario( dr);
            
            return usuario;
        }
        
         
            
    }
}
