using System;
using System.Collections.Generic;
using System.Data;
using StackExchange.Redis;
using Newtonsoft.Json;


namespace HCSoft.POS.Data
{
    public class Usuarios
    {
        private string cadenaCache = "";

        public List<Objetos.Usuario> Lista()
        {

            try
            {
                List<Objetos.Usuario> listaRetorno = new List<Objetos.Usuario>();
                DataTable dtUsuarios = new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM base_usuarios");
                if (dtUsuarios.Rows.Count > 0) {
                    string usuarios = new HCSoft.Util.Cache().Actualizar("usuarios", dtUsuarios);
                    listaRetorno = JsonConvert.DeserializeObject<List<Objetos.Usuario>>(usuarios);
                }
         
                return listaRetorno;
            }
            catch (Exception)
            {
                string usuarios = new HCSoft.Util.Cache().Lee("usuarios");
                List<Objetos.Usuario> lista = JsonConvert.DeserializeObject<List<Objetos.Usuario>>(usuarios);
                return lista;
            }


        }
    }
}
