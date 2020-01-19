using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoyPlaca
{
    class Program
    {
        static void Main(string[] args)
        {
            String verifyingData;
            //Input
            String plateNumber = "AAA-1239";
            DateTime time = new DateTime(2020, 01, 17, 00, 59, 59);

            //            Function
            Functions verificar = new Functions();
            verifyingData = verificar.ChechkPicoPlaca(time, plateNumber);


            //Output
            Console.WriteLine("The vehicle license plate entered was: " + plateNumber);
            Console.WriteLine("The day entered was: " + time);
            Console.WriteLine(verifyingData);



            Console.ReadLine();

        }
    }
}