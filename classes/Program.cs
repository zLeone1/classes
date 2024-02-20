using classes;

Console.WriteLine("Add Date in the format dd/MM/yyyy");
string dateString = Console.ReadLine();
DateTime parsedDate = DateUtility.ParseDate(dateString);
Console.WriteLine($"Parsed Date: {parsedDate}");

DateTime currentDate = DateTime.Now;
TimeSpan difference = DateUtility.CalculateDateDifference(parsedDate, currentDate);
Console.WriteLine($"Difference from parsed date to current date: {difference.Days} days");

string formattedDate = DateUtility.FormatDate(currentDate, "dd/MM/yyyy");
Console.WriteLine($"Formatted current date: {formattedDate}");
