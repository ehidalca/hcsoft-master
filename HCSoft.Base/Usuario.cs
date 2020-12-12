using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using HCSoft.Base.Objetos;
using HCSoft.Base.Data;
using System.Data;

namespace HCSoft.Base
{
   public class Usuario
    {
        int cliente_id = 0;
      
       

        public DataTable Listar()
        {

            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("select * from  base_usuarios where eliminado=0");

            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Insertar(string nombre, string email, string password, string usuario, string imagen)
        {
        
            try
            {
                DateTime fechahora = DateTime.Now;
                int id = 0;
                id = new HCSoft.Util.ConexionMy().EjecutaConsulta("insert into base_usuarios(nombre, email, clave,usuario, imagen, creado) values('" + nombre  + "','" + email + "','" + password + "', '" +usuario + "','"+ imagen + "','"+ fechahora.ToString("yyyy-MM-dd H:mm:ss")+"')");
                if (id != 0)
                    {
                      return true;
                    }
                return false;

            }
            catch (Exception)
	        {
		
		        throw;
	        }
        }
        public bool Eliminar(int usuarioId)
        {

            try
            {
               
                int id = 0;
                id = new HCSoft.Util.ConexionMy().EjecutaConsulta(" UPDATE base_usuarios SET eliminado=1 WHERE id =" + usuarioId  );
                if (id != 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }  
        public bool Actualizar(string nombre , string email, string password, string usuario, bool estado , int usuarioId, string imagen)
        {
            try
            {
                int id = 0;
                id = new HCSoft.Util.ConexionMy().EjecutaConsulta("UPDATE base_usuarios  SET nombre ='" + nombre  + "', email='" + email  + "',clave='" + password + "', usuario='" + usuario  + "', estado=" + estado + ", imagen ='"+ imagen +"' where id=" + usuarioId + "");
                if (id != 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public bool ActualizaPerfil(int idusuario, List<ObjPerfil> perfiles)
        {

            try
            {
                return new  Perfil().ActualizarPerfil(idusuario, perfiles);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public bool ActualizarPassword(string email, string password)
        {
            try
            {
                if (new DatUsuario(this.cliente_id).VerificaExistencia(email))
                {
                    string passwordEncriptada =  Util.Seguridad.Encriptar(password);
                    return new DatUsuario(this.cliente_id).ActualizaPassword(email, passwordEncriptada);
                }
                else
                {

                    throw new System.ArgumentException("No existe","El usuario no existe");
                }
               
            }
            catch (Exception)
            {
                
                throw;
            }
        
        
        }
        public DataTable ObtieneUsuario( int idusuario)
        {

            try
            {
                string query = "SELECT  * FROM base_usuarios WHERE id='" + idusuario + "'";
                DataTable dt = new Util.ConexionMy().EjecutaConsultaDt(query);
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }
        public bool Registrar(string usuario, string nombre,string email, string password, int paisId)
        {
            try
            {
                int id = 0;
                string codigoActivacion = GeneraCodigo(15);
                   id = new HCSoft.Util.ConexionMy().EjecutaConsulta("INSERT INTO usuarios(usuario,nombre, email, clave, paisId, codigoActivacion) VALUES('" + usuario + "', '" + nombre + "', '" + email + "','" + password + "', " + paisId + ", '"+codigoActivacion +"')");

                if (id != 0)
                {
                    if (new HCSoft.Base.Usuario().EnviarEmailRegistro(email, codigoActivacion))
                    {
                        return true;
                    }
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }  
        public static string GeneraCodigo(int length)
        {    Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public bool EnviarEmailRegistro(string email, string codigo)
        {
            try
            {
                ArrayList destinatarios = new ArrayList();
                destinatarios.Add(email);
                string mensaje = "<h2> Confirmación de Registro y Activación </h2>" +
                    "<br>" +
                    "Hola, Bienvenido a HT" +
                    "<br>" +
                    "El Codigo de Activacion es :" + codigo;

               return   new HCSoft.Util.Email().EnviaEmail("Confirmación de Registro y Activación", mensaje, destinatarios);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool ActivarCuenta(string email, string codigo)
        {
            try
            {
                DataTable dtCuenta = new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM usuarios where email = '" + email + "' and  alta = 0 and codigoActivacion='"+ codigo +"' ");
                if (dtCuenta.Rows.Count > 0)
                {

                    int id = 0;
                    id =new HCSoft.Util.ConexionMy().EjecutaConsulta("UPDATE usuarios set alta =1 where email='" + email + "' and codigoActivacion ='" + codigo + "'");
                    if (id != 0)
                    {
                        return true;
                    }

                    return false;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}
