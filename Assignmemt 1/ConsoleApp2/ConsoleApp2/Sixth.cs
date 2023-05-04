using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Sixth
    {
        public static void Main()
        {
            Console.WriteLine("Enter size of array");
            Int64 n = Convert.ToInt64(Console.ReadLine()); 

            
            Int64[] arr = new Int64[n];
            Console.WriteLine("Enter {0} Numbers", n);
            Int64 sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt64(Console.ReadLine());
                sum += arr[i];

            }
            Array.Sort(arr);   
            Array.Reverse(arr);
            Console.WriteLine("Top 10 Element are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);

            }
            

        }
    }
}
