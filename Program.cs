using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Mover
{
    class Program
    {

        static void Main(string[] args)
        {
            string source = @"C:\Users\Andrew\Desktop\folder1\";         // source folder
            string dest = @"C:\Users\Andrew\Desktop\folder2\";           // destination folder

            DirectoryInfo dir = new DirectoryInfo(source);   // DirectoryInfo.GetFiles()
            Console.WriteLine("These files have been created or modified in the last 24 hours and have been relocated:\n");
            foreach (var file in dir.GetFiles())
            {
                DateTime lastModTime = File.GetLastWriteTime(source);  
                DateTime now = DateTime.Now;
                DateTime timeSpan = now - new TimeSpan(0, 24, 0, 0);

                if (lastModTime >= timeSpan)
                {
                    try
                    {
                        File.Move(source + file, dest + file);
                        Console.WriteLine(file.Name + " has been moved to " + dest + "\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("No files have been created or modified in the last 24 hours.");
                }
            }
            Console.ReadLine();     
        }
    }
}
