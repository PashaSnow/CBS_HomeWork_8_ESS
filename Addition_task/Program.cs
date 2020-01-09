using System;

namespace Addition_task
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Input your birthday: ");
            Console.Write("year - ");
            int yearInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("month - ");
            int monthInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("day - ");
            int dayInput = Convert.ToInt32(Console.ReadLine());

            DateTime birthday = new DateTime(yearInput, monthInput, dayInput); // дата рождения
            DateTime today = DateTime.Now;
            DateTime startCount; // к этому дню будет итди счет 
            TimeSpan day;

            // если день рождение в этом году был, считать до ДН в следующем году
            if (today.Month >= birthday.Month && today.Day > birthday.Day)
            {
                startCount = new DateTime(today.Year + 1, monthInput, dayInput);
            }
            else
            {
                startCount = new DateTime(today.Year, monthInput, dayInput);
            }

            day = startCount - today;
            Console.WriteLine($"До дня рождения осталось {day.Days} дней");

            Console.WriteLine();
        }
    }
}


