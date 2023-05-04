using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Fifth
    {
        public static void Main()
        {
            Int64[] arr = new Int64[10];
            Console.WriteLine("Enter 10 Numbers");
            Int64 sum = 0;
            for(int i=0;i<10;i++)
            {
                arr[i]=Convert.ToInt64(Console.ReadLine());
                sum += arr[i];

            }
            Console.WriteLine("Sum = {0}", sum);
            
        }
    }
}
