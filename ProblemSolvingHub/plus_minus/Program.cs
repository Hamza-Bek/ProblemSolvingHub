class Program
{
    static void plusMinus(List<double> arr)
    {
        int Length = arr.Count;
        Console.WriteLine(((double)arr.Count(n => n > 0) / Length).ToString("F6"));
        Console.WriteLine(((double)arr.Count(n => n < 0) / Length).ToString("F6"));
        Console.WriteLine(((double)arr.Count(n => n == 0) / Length).ToString("F6"));
    }

    static void Main(string[] args)
    {
        List<double> arr = new List<double> { -4, 3, -9, 0, 4, 1 };
        plusMinus(arr);

        Console.ReadLine(); // Keeps console open to see output
    }
}