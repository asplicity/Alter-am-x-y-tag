using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Wan bist du geboren?");
        var cultureInfo = new CultureInfo("de-DE");
        var Birthday = DateTime.Parse(Console.ReadLine() ?? string.Empty, cultureInfo);
        Console.WriteLine(Birthday);
        Console.WriteLine("nenne ein Datum");
        var date = DateTime.Parse(Console.ReadLine() ?? string.Empty, cultureInfo);
        Console.WriteLine(date);
        var difference = date - Birthday;
        var days = difference.Days;
        var Years = days / 365;
        var Months = (days % 365) / 30; 
        var Days = (days % 365) % 30;
        Console.WriteLine($"Du wirst am {date} {Years} Jahre, {Months} Monate und {Days} Tage alt sein");
    }
}