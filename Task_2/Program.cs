using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class Printer
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)MyColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)MyColor.DarkBlue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case (int)MyColor.DarkGreen:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.WriteLine(stroka);
        }
    }

    enum MyColor
    {
        Red = 1,
        DarkBlue,
        DarkGreen
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Уведите строку");
            string stroka = Console.ReadLine();
            Console.WriteLine("Выберите цвет (1 - красный; 2 - синий; 3 - синий) - ");
            int color = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 15));

            Printer.Print(stroka, color);
        }
    }
}
