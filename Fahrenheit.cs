using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programs
{
    class Fahrenheit
    {
        public int getdata()
        {
            Console.WriteLine("Enter Celsius Value : ");
            int c = Convert.ToInt32(Console.ReadLine());
            return c;
        }
        class Fahrenheit2 : Fahrenheit
        {
            public int putdata(int c)
            {
                int f = (c * 9 / 5) + 32;
                Console.WriteLine("The Value Of Celsius To Fahrenheit Is : "+f);
                Console.ReadLine();
                return f ;
            }
        }

        public static void Main(string[] args)
        {
           Fahrenheit2 op2 = new Fahrenheit2();
           int f = op2.getdata();
           op2.putdata(f);
        }
    }
}
