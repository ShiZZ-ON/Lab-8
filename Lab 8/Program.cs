//using System.Collections.Concurrent;
//using System.Data;

//DateTime data1 = new DateTime();
//Console.WriteLine(data1);

//DateTime dateNow = DateTime.Now;
//Console.WriteLine(dateNow);

//DateTime date2 = new DateTime(2026, 11, 21);
//Console.WriteLine(date2);

//DateTime date3 = new DateTime(2026, 11, 21, 12,37,45);
//Console.WriteLine(date3);

//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.UtcNow);
//Console.WriteLine(DateTime.Today);

//Console.WriteLine(dateNow.Year);
//Console.WriteLine(dateNow.Month);
//Console.WriteLine(dateNow.Day);
//Console.WriteLine(dateNow.Date);
//Console.WriteLine(dateNow.Minute);
//Console.WriteLine(dateNow.Hour);
//Console.WriteLine(dateNow.Second);
//Console.WriteLine(dateNow.Millisecond);
//Console.WriteLine(dateNow.Microsecond);
//Console.WriteLine(dateNow.Nanosecond);
//Console.WriteLine(dateNow.Kind);

//DateTime date4 = DateTime.Parse("2027-5-09");
//Console.WriteLine(date4);

////операции 4

//Console.WriteLine(date4.Add(new TimeSpan(34, 12, 78)));
//Console.WriteLine(date4.AddDays (8));
//Console.WriteLine(date4.AddDays(-7));
//Console.WriteLine(date4.AddHours(80));
//Console.WriteLine(date4.AddHours(80));
//Console.WriteLine(date4.AddTicks(854853485));
//Console.WriteLine(date4.Subtract(DateTime.Now));
//Console.WriteLine(date4.CompareTo(dateNow));
//Console.WriteLine(date4 == dateNow);
//Console.WriteLine(dateNow.Day);
//Console.WriteLine(dateNow.DayOfWeek);
//Console.WriteLine(dateNow.DayOfYear);
//Console.WriteLine(dateNow.ToLocalTime);
//Console.WriteLine(dateNow.ToLongDateString());

////Дата время во всех форматах

//Console.WriteLine($"D: {dateNow.ToString("D")}");
//Console.WriteLine($"d: {dateNow.ToString("d")}");
//Console.WriteLine($"F: {dateNow.ToString("F")}");
//Console.WriteLine($"f: {dateNow.ToString("f")}");

////DateOnly

//DateOnly d0nly = new DateOnly();
//Console.WriteLine(d0nly);
//DateOnly d3 = new DateOnly(2026, 11, 21);
//Console.WriteLine(d3);

//TimeOnly time5 = new TimeOnly();
//Console.WriteLine(time5);
//Console.WriteLine(time5.Ticks);
//Console.WriteLine(time5.Hour);
//Console.WriteLine(time5.Second);


//часть1

int hours = 14;
int minutes = 35;
int seconds = 42;
int milliseconds = 125;

DateTime combinedDateTime = new DateTime
(
    DateTime.Now.Year,
    DateTime.Now.Month,
    DateTime.Now.Day,
    hours,
    minutes,
    seconds,
    milliseconds
);

Console.WriteLine($"объединенное значение: {combinedDateTime}");
Console.WriteLine($"ток время: {combinedDateTime.ToString("HH:mm:ss.fff")}");
Console.WriteLine("");


//часть2 

Console.Write("введи дату, день месяц и год, да: ");
DateTime inputDate = DateTime.Parse(Console.ReadLine());

int year = inputDate.Year;

if (DateTime.IsLeapYear(year))
{
    Console.WriteLine($"{year} год высокосный");
}
else
{
    int nextYR = year + 1;
    while (!DateTime.IsLeapYear(nextYR))
    {
        nextYR++;
    }

    int yearsLeft = nextYR - year;
    Console.WriteLine($"{year} год не высокосный ");
    Console.WriteLine($"ближайший высокосный в: {nextYR}");
    Console.WriteLine($"осталось лет: {yearsLeft}");
}
