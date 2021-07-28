using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210728_ex2_표원식
{
    class Class1
    {

       public static void Main()
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, ref mean);

            Console.WriteLine("평균 : {0}", mean);
        }

        public static void Mean(
            double a, double b, double c,
            double d, double e, ref double mean)

        { 
            mean = (a + b + c + d + e) / 5; 

            //다 더하면 15 
        
        }








    }
}
