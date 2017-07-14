using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CountWorkingDays
{
    public static void Main(string[] args)
    {
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

        DateTime[] oficialHollidays = AddHollidays();
        int workingDaysCount = 0;

        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
            {
                continue;
            }

            bool isHoliday = false;

            for (int i = 0; i < oficialHollidays.Length; i++)
            {
                DateTime checkHoliday = oficialHollidays[i];
                if (currentDate.Day == checkHoliday.Day && currentDate.Month == checkHoliday.Month)
                {
                    isHoliday = true;
                }
            }

            if (!isHoliday)
            {
                workingDaysCount++;
            }
        }
        Console.WriteLine(workingDaysCount);
    }

    private static DateTime[] AddHollidays()
    {
        DateTime[] oficialHollidays = new DateTime[]
            {
                new DateTime (2017, 1, 1),
                new DateTime (2017, 3, 3),
                new DateTime (2017, 5, 1),
                new DateTime (2017, 5, 6),
                new DateTime (2017, 5, 24),
                new DateTime (2017, 9, 6),
                new DateTime (2017, 9, 22),
                new DateTime (2017, 11, 1),
                new DateTime (2017, 12, 24),
                new DateTime (2017, 12, 25),
                new DateTime (2017, 12, 26)
            };
        return oficialHollidays;
    }
}

