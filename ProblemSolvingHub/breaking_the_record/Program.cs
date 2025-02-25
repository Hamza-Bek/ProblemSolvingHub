class Program
{
    public static List<int> breakingRecords(List<int> scores)
    {
        int maxRecord = scores[0], minRecord = scores[0];
        int mostPoints = 0, leastPoints = 0;
        
        for(int i = 1; i < scores.Count; i++)
        {
            if(scores[i] > maxRecord)
            {
                maxRecord = scores[i];
                mostPoints ++;
            }
            
            else if(scores[i] < minRecord)
            {
                minRecord = scores[i];
                leastPoints ++;
            }
        }
        
        return new List<int> {mostPoints , leastPoints};
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> scores = new List<int> {10, 5, 20, 20, 4, 5, 2, 25, 1};
        List<int> result = Program.breakingRecords(scores);
        
        Console.WriteLine(string.Join(" ", result));
    }
}