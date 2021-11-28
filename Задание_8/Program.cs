using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8
{
    class Program
    {
        //Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите директорию любой папки на своем компе, имеющую вложенные директории:");
            string path = Console.ReadLine();
            string[] X = Directory.GetDirectories(path);
            foreach (string D in X)
            {
                Console.WriteLine("Каталог: {0}", D);
                string[] Y = Directory.GetDirectories(D);
                foreach (string P in Y)
                {
                    Console.WriteLine("Подкаталог: - {0}", P);
                }
            }
            Console.ReadKey();
        }
    }
}
