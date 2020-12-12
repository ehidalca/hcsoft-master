using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace HCSoft.Util
{
   public static class Validacion
    {
        
       public static bool Requerido(ErrorProvider error,TextBox input)
       {
          
           if (input.Text == "")
           {
              
               error.SetError(input, "Campo Requerido");
              // input.BackColor = System.Drawing.Color.LightYellow;
               return false;
           }
           else
           {
               error.Clear();
              
               return true;
           
           }
       }

        public static bool Requerido(ComboBox  cmb)
        {
            ErrorProvider error = new ErrorProvider();

            if (cmb.SelectedValue == "")
            {

                error.SetError(cmb, "Campo Requerido");
                // input.BackColor = System.Drawing.Color.LightYellow;
                return false;
            }
            else
            {
                error.Clear();

                return true;

            }
        }
        public static bool EsAlfanumerico(string cadena)
        {
        
         string pattern = @"^[a-zA-Z]*\d*$";
         Regex r = new Regex(pattern);

            if (r.Match(cadena).Success)
                return true;
            else
                return false;



        }

        



           

    }
}
