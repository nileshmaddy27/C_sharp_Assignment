using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Third
    {
        public static void Main()
        {
            Char ch;
            ch=Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch);
            if((ch>='a' && ch<='z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("Character");
            }
            else if(ch>='0' && ch<='9')
            {
                Console.WriteLine("Integer");
            }
            else { Console.WriteLine("Special Character"); }
            
            //Fourth f=new Fourth();
            //Console.WriteLine(f.fo)
        }
    }
}
