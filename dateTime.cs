//Working with Date Time
DateTime date1 = new DateTime(2024, 3, 9); // Replace with your desired date
DateTime date2 = new DateTime(2024, 01, 02); // Replace with your desired date

TimeSpan difference = date1.Subtract(date2);
int daysPassed = difference.Days;

Console.WriteLine($"Days passed between {date1} and {date2}: {daysPassed}");


DateTime hireDate = new DateTime(2023, 3, 9,14,30,0);
Console.WriteLine(hireDate.ToString("dddd-MMM-yy hh:mm:ss")); ///long Date

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(2, 30, 30);
DateTime endHour = startHour.Add(workTime);
Console.WriteLine(endHour.ToString("F"));

Console.WriteLine(startHour.ToLongDateString());
Console.WriteLine(endHour.ToShortTimeString());
