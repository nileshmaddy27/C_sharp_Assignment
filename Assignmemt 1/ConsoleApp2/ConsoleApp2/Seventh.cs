using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Seventh
    {
        public static void Main()
        {
            Console.WriteLine("Enter Your Full Name: ");
            string s=Convert.ToString(Console.ReadLine());
            string[] nme = s.Split(' ');
            Console.WriteLine("First Name: {0}\nLastName: {1}", nme[0], nme[1]);

        }
        
        //C
    }
}
