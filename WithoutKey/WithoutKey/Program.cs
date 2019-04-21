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
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            text = text.Replace(" ", "");
            Console.Write("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
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
            string encrypted ="";
            for(int i = 0; i < columns; i++)
            {

                encrypted += Array[i];
                
            }
            for (int i = 0; i < encrypted.Length; i++)
            {
                Console.Write(Char.ToUpper(encrypted[i]));
                k++;
                if (k == 5 && i != encrypted.Length-1)
                {
                    Console.Write(" ");
                    k = 0;

                }

            }
            Console.ReadLine();
        }
    }
}
