using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoyPlaca
{
    public class Functions
    {
        public string ChechkPicoPlaca(DateTime time, String plate)
        {
            String valor = time.ToString("dddd", new CultureInfo("en-US"));

            if (CheckRanges(time))
            {
                if (VerifyPlate(plate).Equals(valor))
                {
                    return "This car has vehicle restriction";
                }
                else
                {
                    return "This car has no vehicle restriction";
                }
            }
            else
            {
                return "This car has no vehicle restriction";
            }
            //return "This car has no vehicle restriction";
        }

        //Check the day
        public String VerifyPlate(String plate)
        {
            String lastDigit = plate.Substring(plate.Length - 1, 1);
            String day = null;
            switch (lastDigit)
            {
                case "1":
                case "2":
                    //statements
                    day = "Monday";
                    break;
                case "3":
                case "4":
                    //statements 
                    day = "Tuesday";
                    break;
                case "5":
                case "6":
                    //statements 
                    day = "Wednesday";
                    break;
                case "7":
                case "8":
                    //statements
                    day = "Thursday";
                    break;
                case "9":
                case "0":
                    //statements 
                    day = "Friday";
                    break;
            }
            return day;
        }
        //Check Peak and Plate Ranges
        public Boolean CheckRanges(DateTime hour)
        {

            if (CheckSchedule(hour, new TimeSpan(7, 00, 0), new TimeSpan(9, 30, 0)))
            {
                return true;
            }
            else if (CheckSchedule(hour, new TimeSpan(16, 00, 0), new TimeSpan(19, 30, 0)))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        //Check Schedule Pico y Placa
        public bool CheckSchedule(DateTime hour, TimeSpan ts1, TimeSpan ts2)
        {
            Boolean checker = false;
            DateTime rango1 = DateTime.Now;
            DateTime rango2 = DateTime.Now;
            rango1 = rango1.Date + ts1;
            rango2 = rango2.Date + ts2;

            if ((hour.Hour >= rango1.Hour) && (hour.Hour <= rango2.Hour))
            {
                if (hour.Hour == rango1.Hour)
                {
                    if (hour.Minute >= rango1.Minute)
                    {
                        checker = true;
                    }

                }
                else if (hour.Hour == rango2.Hour)
                {
                    if (hour.Minute <= rango2.Minute)
                    {
                        checker = true;
                    }

                }
                else { checker = true; }
            }
            return checker;
        }
    }
}
