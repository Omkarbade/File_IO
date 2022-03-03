using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    public class FileOperation
    { 
        //check File Exists or Not.
        public void CheckFile(string path)
        {
            Console.WriteLine("Check File Exists or Not");
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
                Console.WriteLine("File doesn't Exists");
        }
        //Read All Lines from File
        public void ReadAllLinesFromFile(string path)
        {
            Console.WriteLine();
            Console.WriteLine("Read All Lines From File");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        //Read All Text From File.
        public void ReadAllTextFromFile(string path)
        {
            Console.WriteLine();
            Console.WriteLine("Read All Text From File");
            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        //Copy File from one Source to Another.
        public void CopyFileSourceToDest(string path)
        {
            Console.WriteLine();
            Console.WriteLine("Copy File from one Source to Another Source");
            string path1 = @"C:\Users\OMKAR BADE\source\repos\File_IO\File_IO\File\File4.txt";
            try
            {
                File.Copy(path, path1);
                Console.WriteLine("File Copied!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            DeleteFile(path1);
        }
       public void DeleteFile(string path)
        {
            Console.WriteLine();
            Console.WriteLine("Delete a File");
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File Deleted!");
            }
            else
                Console.WriteLine("File Doesn't Exists");
        }
    }
}
