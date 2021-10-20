using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghoul
{
    class Program
    {
        static void Main(string[] args)
        {
            //Графическая часть(graph.)
            Console.SetWindowSize(150, 30);
            Console.SetCursorPosition(65, 0);
            Console.Title = "ZXC";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;


            //Кодировка(Russian)
            var enc1251 = Encoding.GetEncoding(1251);

            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = enc1251;

            int x = 1007;
            int number = 1000;
            Console.WriteLine("Программ фор риал дединсайд");
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine().ToLower();
            if (Console.CapsLock == true)
            {
                Console.WriteLine("Выруби капс");
            }
            if (name == "гуль" || name == "ghoul")
            {
                while (number > -1)
                {
                    number -= 7;
                    x -= 7;
                    Console.WriteLine(x + " - 7 = " + number);

                    System.Threading.Thread.Sleep(5);
                }
                Console.ResetColor();
                Console.WriteLine("Вы... ..." + name);
            }
            else
            {
                Console.ResetColor();
                Console.WriteLine("Доступ запрещён, " + name);
            }
            Console.ReadKey();
        }
    }
}
