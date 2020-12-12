using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCSoft.Util;
using System.Data;

namespace HCSoft.POS
{
   public  class Folios
    {

        public DataTable listar()
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT f.id, c.id as cajaId, f.folio_inicial as folioInicial, f.folio_siguiente as folioSiguiente, f.folio_termino as folioTermino, c.nombre as nombreCaja, t.nombre as tipoDocumento,  t.id as tipoDocumentoId FROM pos_folios f inner join pos_cajas c on f.caja_id= c.id  inner join  pos_tipodocumentos t on f.tipo_documento_id =  t.id");
            }
            catch (Exception )
            {

                throw;
            }

        }

        public DataTable Obtiene(int id)
        {
            try
            {
                return new HCSoft.Util.ConexionMy().EjecutaConsultaDt("SELECT f.id, c.id as cajaId, f.folio_inicial as folioInicial, f.folio_siguiente as folioSiguiente, f.folio_termino as folioTermino, c.nombre as nombreCaja, t.nombre as tipoDocumento,  t.id as tipoDocumentoId FROM pos_folios f inner join pos_cajas c on f.caja_id= c.id  inner join  pos_tipodocumentos t on f.tipo_documento_id =  t.id WHERE f.id="+ id.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool Ingresar(int cajaId, int TipoDocumentoId, string folioInicial, string folioTermino, string folioSiguiente) {
            try
            {
                int respuesta = new HCSoft.Util.ConexionMy().EjecutaConsulta("INSERT INTO pos_folios (caja_id, tipo_documento_id, folio_inicial, folio_termino, folio_siguiente) VALUES(" + cajaId.ToString() + ", " + TipoDocumentoId.ToString() + ",'" + folioInicial.ToString() + "', '" + folioTermino.ToString() + "', '" + folioSiguiente.ToString() + "' )");
               if (respuesta > 0) {
                    return true;
                }
                return false;
             }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Actualizar(int folioId, int cajaId, int TipoDocumentoId, string folioInicial, string folioTermino, string folioSiguiente)
        {
            try
            {
                int respuesta = new HCSoft.Util.ConexionMy().EjecutaConsulta("UPDATE pos_folios  SET caja_id='"+ cajaId.ToString() +"', tipo_documento_id ='"+ TipoDocumentoId.ToString() +"', folio_inicial='"+ folioInicial.ToString()+"', folio_termino= '"+ folioTermino.ToString()+"', folio_siguiente='"+ folioSiguiente.ToString() +"' WHERE  id="+ folioId.ToString());
                if (respuesta > 0)
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

        public int TraerFolio(int caja_id, int tipodocumento_id)
        {
            try
            {
                return new Data.DatFolios().TraeFolio(caja_id, tipodocumento_id);
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
