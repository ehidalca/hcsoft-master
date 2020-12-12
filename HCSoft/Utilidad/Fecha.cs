using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCSoft.Util
{
    public class Fecha
    {

        public string NombreDia(DateTime fecha)
        {
            string dia = fecha.DayOfWeek.ToString();
            string diaretorna = "";

            switch (dia)
            {
                case "Monday":
                    diaretorna = "Lunes";
                    break;
                case "Tuesday":
                    diaretorna = "Martes";
                    break;
                case "Wednesday":
                    diaretorna = "Miercoles";
                    break;
                case "Thursday":
                    diaretorna = "Jueves";
                    break;
                case "Friday":
                    diaretorna = "Viernes";
                    break;
                case "Saturday":
                    diaretorna = "Sabado";
                    break;
                case "Sunday":
                    diaretorna = "Domingo";
                    break;
            }

            return diaretorna;
        }
    }
}
