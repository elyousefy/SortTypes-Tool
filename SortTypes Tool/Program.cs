using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTypes_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SortTypes Tool";
            Console.WriteLine("Enter the path (ex: C:\\Users\\):");

            string filepath = Console.ReadLine();
            DirectoryInfo d = new DirectoryInfo(filepath);


            foreach (var file in d.GetFiles("*.*"))
            {
                string filename = file.Name;
                string[] filenames = filename.Split('.');

                string extension = filenames[filenames.Length - 1];
                Directory.CreateDirectory(@"C:\SortTypes\" + extension);
                Console.WriteLine("Copy in progress....");
                Console.WriteLine(filename);
                File.Copy(filepath + @"\" + filename, @"C:\SortTypes\" + extension + @"\" + filename, true);
                Console.WriteLine("Copy file successfully !");
                Console.WriteLine("");
            }
            //code
            Console.WriteLine("Finish !");
            Console.ReadKey();
        }
    }
}
