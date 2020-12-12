using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace HCSoft.Util
{
    public  class Log
    {
        private string ruta = "";

        public Log(string ruta) {
            this.ruta = ruta;
        }

        public  bool GuardaError(string descripcion, Exception error)
        {
            using (System.IO.StreamWriter file =

            new System.IO.StreamWriter(@ruta, true))
            {
                file.WriteLine("{0} {1} {2} {3}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString(), descripcion, error.Message);
            }

            return true;
        }

        public static void RegistroLog(string logMessage, string origen, TextWriter w)
        {
	        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
	        w.WriteLine("  :");
	        w.WriteLine("  :{0}", logMessage);
            w.WriteLine("  :{0}", origen);
    	    w.WriteLine("-------------------------------");
    	    // Update the underlying file.
	        w.Flush();
        }
    }
}
