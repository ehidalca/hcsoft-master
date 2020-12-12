using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.POS.Data;
using HCSoft.POS.Objetos;
using System.Data;

namespace HCSoft.POS
{
   public class Ventas
    {
        private string tabla = "ventas";
        public bool Guardar(int usuarioId,int cajaId, int clienteId)
        {
            try
            {
                DateTime fecha = DateTime.Now;
                //Guarda Cabecera Documento
                int idventa = 0;
                idventa = new HCSoft.Util.ConexionMy().EjecutaConsulta("INSERT INTO ventas(cajaId,usuarioId, clienteId, fecha, hora) VALUES(" + cajaId + "," + usuarioId + ", "+clienteId +", '"+ fecha.ToString("yyyy-MM-dd") +"', '"+ fecha.ToString("HH:mm:ss") +"' )");
                

                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable Listar()
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT * FROM " + tabla);
            }
            catch (Exception)
            {

                throw;
            }

        }


       
    }
}
