class Program
{
    static void miniMaxSum(List<int> arr)
    {
        long totalSum = arr.Sum(x => (long) x);
        
        long  lowestNumber = totalSum - arr.Max();
        long highestNumber = totalSum - arr.Min();
                        
        Console.Write(lowestNumber +" "+ highestNumber);

        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        List<int> arr = [1, 2, 3, 4, 5];;

        miniMaxSum(arr);
    }
}
