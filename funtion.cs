using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal interface Imanager
    {
        void ShowList();
        void CreateFile();
        void LoadFile();
        void SaveFile();
        void DeleteFile();
        void UpdateFile();
    }
    public class Manager: Imanager
    {
        public void ShowList() 
        {
            foreach (string path in Directory.EnumerateFiles("F:\\"))
            {
                Console.WriteLine("IN F DIRECTORY: " + path);
            }
        }
        public void CreateFile()
        {
            Console.WriteLine("Nhập tên File tạo:");
            string nameFile = Console.ReadLine();
            //string nameCreateFile = "F:"+  (string)nameFile;
            //Console.WriteLine(nameCreateFile);
            string path = @"F:\"+nameFile;
            Console.WriteLine("Nhập nội dung File");
            string ContextFile = Console.ReadLine();
            
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                File.WriteAllText(path, ContextFile);
            }

        }
        public void LoadFile()
        {
            Console.WriteLine("Nhap file cần mở :");
            string nameFile = Console.ReadLine();
            string path = @"F:\" + nameFile;
            if (!File.Exists(path))
            {
                Console.WriteLine("Specified file no exists.");
            }
            else
            {
                string displayContext = File.ReadAllText(path);
                Console.WriteLine(displayContext);
            }
           
        }
        public void SaveFile()
        {
            Console.WriteLine("Nhap file cần viết :");
            string nameFile = Console.ReadLine();
            string path = @"F:\" + nameFile;
            string createText = Console.ReadLine();
            File.WriteAllText(path, createText);

        }
        public void DeleteFile()
        {
            Console.WriteLine("Nhap file cần xóa :");
           
            string nameFile = Console.ReadLine();
            string path = @"F:\" + nameFile;
            if (!File.Exists(path))
            {
                Console.WriteLine("Specified file no exists.");
            }
            else
            {
                File.Delete(path);
            }
            
            
        }
        public void UpdateFile()
        {
            Console.WriteLine("Nhap file cần xóa :");
            string nameFile = Console.ReadLine();
            string path = @"F:\" + nameFile;
            Console.WriteLine("Noi dung cacn update");
            string ContextFile = Console.ReadLine();
            File.AppendAllText(path, ContextFile);
        }
    }
    
}
