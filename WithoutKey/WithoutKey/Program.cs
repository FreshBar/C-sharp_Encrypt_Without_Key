using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string check ="y";
            do
            {
                Console.Write("Введите текст: ");
                string text = Console.ReadLine();
                text = text.Replace(" ", "");
                if (text == "")
                {
                    Console.WriteLine("Ничего не введено!");
                    continue;
                }
                Console.Write("Введите количество столбцов: ");
                int columns = Convert.ToInt32(Console.ReadLine());
                if (columns <= 0)
                {
                    Console.WriteLine("Неправильно введено количество столбцов!");
                    continue;
                }

                //Console.WriteLine(text);
                string[] Array = new string[columns];
                int k = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    Array[k++] += text[i];
                    if (k == columns)
                    {
                        k = 0;
                    }
                }

                string encrypted = "";
                for (int i = 0; i < columns; i++)
                {

                    encrypted += Array[i];

                }
                k = 0;
                for (int i = 0; i < encrypted.Length; i++)
                {
                    Console.Write(Char.ToUpper(encrypted[i]));
                    k++;
                    if (k == 5 && i != encrypted.Length - 1)
                    {
                        Console.Write(" ");
                        k = 0;

                    }

                }
                Console.WriteLine("\nХотите продолжить? (y/n)");
                check = Convert.ToString(Console.ReadLine());
            }
            while (check == "y");
        }
    }
}
