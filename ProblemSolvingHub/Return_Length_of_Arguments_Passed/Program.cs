int ArgumentsLength(params object[] args) => args.Length;

Console.WriteLine(ArgumentsLength(5)); // Output: 1
Console.WriteLine(ArgumentsLength(new object(), null, "3")); // Output: 3
