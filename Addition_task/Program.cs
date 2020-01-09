using System;

namespace Addition_task
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Input your birthday {year.month.day}: ");


            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Now;
            DateTime startCount = new DateTime(today.Year, birthday.Month, birthday.Day); ; // к этому дню будет итди счет 
            TimeSpan weitDays;

            // если день рождение в этом году был, считать до ДН в следующем году
            if (today > startCount)
            {
                startCount = new DateTime(today.Year + 1, birthday.Month, birthday.Day);
            }
            
            weitDays = startCount - today;
            Console.WriteLine($"До дня рождения осталось {weitDays.Days} дней");

            Console.WriteLine();
        }
    }
}


