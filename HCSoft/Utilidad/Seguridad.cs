using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.Util
{
   public static class Seguridad
    {
       public static string Encriptar(string cadenaencriptar)
       {
           string result = string.Empty;
           byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaencriptar);
           result = Convert.ToBase64String(encryted);
           return result;
       }

       public static string Desencriptar(this string cadenaAdesencriptar)
       {
           string result = string.Empty;
           byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
           //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
           result = System.Text.Encoding.Unicode.GetString(decryted);
           return result;
       }
    }
}
