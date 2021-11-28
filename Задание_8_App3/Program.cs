using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8_App3
{
    class Program
    {
        //Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к файлу:");
            string path1 = Console.ReadLine();
            string path2 = "Task.txt";
            string path = path1 + "\\" + path2;
            int rowNumber;
            int wordNumber = 0;
            int symbolNumber;
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                string[] rowArray = text.Split('\n');
                rowNumber = rowArray.Length;
                foreach (string row in rowArray)
                {
                    string[] wordArray = row.Split(' ');
                    wordNumber += wordArray.Length;
                }
                symbolNumber = text.Length;
            }            
            Console.WriteLine("Число строк в тексте: {0}", rowNumber);
            Console.WriteLine("Число слов в тексте, разделенных пробелом: {0}", wordNumber);
            Console.WriteLine("Число символов в тексте: {0}", symbolNumber);

            Console.ReadKey();
        }
    }
}
