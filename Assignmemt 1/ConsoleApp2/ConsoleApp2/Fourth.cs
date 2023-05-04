using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Fourth
    {
        public static void Main()
        {
            Int64 num;
            num=Convert.ToInt64(Console.ReadLine());
            for(int  i = 2; i < Math.Sqrt(num); i++) { 
                if(num%i == 0)
                {
                    Console.WriteLine("Prime Number");
                    return;
                }
            }
            Console.WriteLine("Not Prime Number");

        }
    }
}
