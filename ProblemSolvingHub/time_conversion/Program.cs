class Program
{
    static string timeConversion(string s)
    {
       return DateTime.ParseExact(s, "hh:mm:sstt", null).ToString("HH:mm:ss");
    }

    static void Main(string[] args)
    {
        string s = "07:05:45PM";
        Console.WriteLine(timeConversion(s));
    }
}