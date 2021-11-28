using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8_App2
{
    class Program
    {
        //Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
        static void Main(string[] args)
        {
            string path = @"C:\Users\gorshkov\Desktop\ИТМО\Задание_8\Test.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path, false))
            {

            }    
            /*{
                Random random = new Random();
                array [i] = random.Next();
                for (int i = 0; i < 10; i++)
                {
                    sw.Write("Старт программы");
                }
                sw.WriteLine("Старт программы");
                sw.WriteLine("Ошибка");
            }




            /*string path = "Logs2/Log.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Старт программы");
                sw.WriteLine("Ошибка");
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();

            /*if (!File.Exists(path))
            {
                File.Create(path);
            }
            
            
            /*DirectoryInfo directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }

            /*string path = "Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }*/

            /*DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
            {
                Console.WriteLine("Название: {0}", d.Name);
                if (d.IsReady)
                {
                    Console.WriteLine("Объем диска: {0}", d.TotalSize);
                    Console.WriteLine("Свободно: {0}", d.AvailableFreeSpace);
                }
                Console.WriteLine();
            }
            Console.ReadKey();*/
        }
    }
}
