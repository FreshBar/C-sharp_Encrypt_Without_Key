using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutKey
{
    class Program
    {
        static void Encrypt()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            text = text.Replace(" ", "");
            if (text == "")
            {
                Console.WriteLine("Ничего не введено!");
                return;
            }
            Console.Write("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            if (columns <= 0)
            {
                Console.WriteLine("Неправильно введено количество столбцов!");
                return;
            }

            // Console.WriteLine(text);
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
                Console.WriteLine(Array[i]);
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

        }
        static void Decrypt()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            text = text.Replace(" ", "");
            if (text == "")
            {
                Console.WriteLine("Ничего не введено!");
                return;
            }
            Console.Write("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            if (columns <= 0)
            {
                Console.WriteLine("Неправильно введено количество столбцов!");
                return;
            }
            int symbsInCol = text.Length / columns;
            int reminder = text.Length - symbsInCol * columns;
            string[] strs = new string[columns];
            int counter = 0;
            for(int i = 0; i <columns; i++)
            {
                int symbsInStr = symbsInCol;
                if(reminder > 0)
                {
                    symbsInStr++;
                    reminder--;
                }
                for (int j = counter; j < counter +symbsInStr; j++)
                {
                    strs[i] += text[j];
                }
                counter += symbsInStr;
            }
            int pos = text.Length - symbsInCol * columns;
            string decrypt = "";
            while(strs[0] != "")
            {
                pos--;
                pos += columns;
                pos %= columns;
                decrypt += strs[pos][strs[pos].Length - 1];
                strs[pos] = strs[pos].Remove(strs[pos].Length - 1);
                Console.WriteLine(decrypt[decrypt.Length-1]);

            }
            Console.WriteLine(decrypt);
            decrypt = new string(decrypt.ToCharArray().Reverse().ToArray());
            Console.WriteLine(decrypt);
         }
        static void Main(string[] args)
        {
            string check ="y";
            do
            {
                Console.Write("Зашифровать-1\nРасшифровать-2\n");
                int menu = Convert.ToInt32(Console.ReadLine());
                if(menu == 1)
                {
                    Encrypt();

                }
                else if (menu == 2)
                {
                    Decrypt();
                }
                else
                {
                    Console.Write("Выбран несуществующий пункт!");
                }
                
                Console.WriteLine("\nХотите продолжить? (y/n)");
                check = Convert.ToString(Console.ReadLine());
            }
            while (check == "y");
        }
    }
}
