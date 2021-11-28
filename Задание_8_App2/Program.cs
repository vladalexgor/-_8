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
            Console.WriteLine("Введите директорию любой папки на своем компе, в которой будет создан файл:");
            string pathCatalogue = Console.ReadLine();
            string fileName = "Test.txt";
            string path = pathCatalogue + "\\" + fileName;
            int a = -100;
            int b = 100;
            int n = 10;
            Random random = new Random();
            int[] array = new int[n];
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(a, b);
                    sw.Write("{0} ", array[i]);
                }
            }
            //sum - сумма десяти случайных чисел, записанных в текстовый файл по ссылке.
            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string m = sr.ReadToEnd();
                string[] stringArray = m.Split();
                for (int i = 0; i < n; i++)
                {
                    int d = Convert.ToInt32(stringArray [i]);
                    sum += d;
                }
            }
            Console.WriteLine("Сумма десяти случайных чисел, записанных в файле \"Test.txt\" по ссылке: {0}", sum);
            Console.ReadKey();
        }
    }
}
