using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Eight
    {
        public static void Main()
        {
            Console.WriteLine("Enter string:");
            string s = Convert.ToString(Console.ReadLine());
            Int64 count = 0;
            int n =s.Length;
            for(int i=0;i<n;i++)
            {
                if (s[i]=='a' || s[i]=='e' || s[i] == 'o' || s[i] == 'i'|| s[i] == 'u' )
                {
                    count++;
                }
            }

            Console.WriteLine("Number of vowel are {0}", count);
        }

        //C
    }
}
