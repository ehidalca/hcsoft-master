using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace HCSoft.Agenda
{
    public class Categorias
    {
        public DataTable Listar()
         {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM agenda_categorias");
            }
            catch (Exception)
            {

                throw;
            }

            }

        public DataTable Consultar(int idcategoria)
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM agenda_categorias  where id="+ idcategoria.ToString() );
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Actualizar(string nombre,  int idcategoria)
        {
            try
            {
                int id = 0;
                  id = new HCSoft.Util.ConexionMy().EjecutaConsulta("UPDATE agenda_categorias SET nombre ='"+ nombre +"' where id=" + idcategoria.ToString());
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

        public bool Eliminar(string nombre, int idcategoria)
        {
            try
            {
                int id = 0;
                   id = new HCSoft.Util.ConexionMy().EjecutaConsulta("UPDATE agenda_categorias SET estado =0  where id=" + idcategoria.ToString());
                if (id != 0)
                { return true; }

                return false;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Registrar(string nombre)
        {
            try
            {
                int id = 0;
                id = new HCSoft.Util.ConexionMy().EjecutaConsulta("INSERT INTO agenda_categorias(nombre) VALUES('" + nombre + "')");
                if (id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }


        }


    }
}
