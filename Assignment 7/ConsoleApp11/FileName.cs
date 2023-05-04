using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class FileName
    {
        public static void Main()
        {
            //Console.WriteLine("Create Directory");

            //Directory.CreateDirectory(@"C:\\Users\\Nilesh.Kumar\\svam\\demo");


            //Console.WriteLine("Cretae two more directory");
            //Directory.CreateDirectory(@"C:\\Users\\Nilesh.Kumar\\svam\\demo\\demo1");
            //Directory.CreateDirectory(@"C:\\Users\\Nilesh.Kumar\\svam\\demo\\demo2");


            //Console.WriteLine("Create file");
            //string fileName = @"C:\\Users\\Nilesh.Kumar\\svam\\demo\\demo1\\t1.txt";
            //if(File.Exists(fileName))
            //{
            //    File.Delete(fileName);  
            //}
            //else {
            //    FileStream fileStream = new FileStream(fileName, FileMode.Create);
            //}

            //Console.WriteLine("Create file");
            //string fileName = @"C:\\Users\\Nilesh.Kumar\\svam\\demo\\demo2\\t1.txt";
            //if (File.Exists(fileName))
            //{
            //    File.Delete(fileName);
            //}
            //else
            //{
            //    FileStream fileStream = new FileStream(fileName, FileMode.Create);
            //}

            //Console.WriteLine("Writing in txt file");
            //StreamWriter streamWriter = new StreamWriter(@"C:\\Users\\Nilesh.Kumar\\svam\\demo\\demo1\\t1.txt");
            //streamWriter.WriteLine("This is my first txt file");
            //streamWriter.WriteLine("Here we will write some text");
            //streamWriter.Close();

            //Console.WriteLine("Copying one file to another");
            //string fileName1 = @"C:\\Users\\Nilesh.Kumar\\svam\\demo\\demo1\\t1.txt";
            //string fileName2 = @"C:\\Users\\Nilesh.Kumar\\svam\\demo\\demo2\\t1.txt";
            //if (File.Exists(fileName2))
            //{
            //    File.Delete(fileName2);
            //}

            //File.Copy(fileName1, fileName2);



            //Console.WriteLine("Get file Name in directory");
            //string fileName1 = @"C:\\Users\\Nilesh.Kumar\\svam\\demo\\demo1";
            //string[] fileName=Directory.GetFiles(fileName1);
            //foreach (string fileName2 in fileName)
            //{
            //    Console.WriteLine(fileName2);
            //    FileInfo file = new FileInfo(fileName2);
            //    DateTime dt = file.CreationTime;
            //    Console.WriteLine("Creation Time: " + dt);
            //}


            Console.WriteLine("Delete Directory");
            string root = @"C:\\Users\\Nilesh.Kumar\\svam\\demo\\delete";
            if (Directory.Exists(root))
            {
                Directory.Delete(root, true);
            }






        }
    }
}
