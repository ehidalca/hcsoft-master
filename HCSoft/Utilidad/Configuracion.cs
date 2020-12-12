using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.Util
{
     public class VariablesConfiguracion
    {
        public string valor(string nombre)
        {
            string linea;
            System.IO.StreamReader file =  new System.IO.StreamReader(@"config.cnf");
            while ((linea = file.ReadLine()) != null)
            {
                Char delimiter = '=';
                String[] substrings = linea .Split(delimiter);
                if (substrings[0].Trim() == nombre)
                {

                    return substrings[1];
                   
                }
            }


            return "";

        }

    }
}
