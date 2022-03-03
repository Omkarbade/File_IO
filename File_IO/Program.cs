using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Io Operations");
            string path = @"C:\Users\OMKAR BADE\source\repos\File_IO\File_IO\File\File.txt";
            FileOperations(path);
            Console.ReadKey();
        }
        //Method to call all methods of FileOperation class.
        public static void FileOperations(string path)
        {
            FileOperation file = new FileOperation();
            file.CheckFile(path);
            file.ReadAllLinesFromFile(path);
            file.ReadAllTextFromFile(path);
            file.CopyFileSourceToDest(path);
        }
    }
}
