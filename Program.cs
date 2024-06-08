internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var memo = new Dictionary<int, int>();
        var memot = new Dictionary<int, int>();


        int fibResult = fib(10, memo);
        System.Console.WriteLine(fibResult);

        int tribResult = trib(8, memot);
        System.Console.WriteLine(tribResult);


    }

    public static int fib(int input, Dictionary<int, int> memo)
    {
        if (input == 0 || input == 1)
        {
            memo[input] = 1;
            return 1;
        }

        if (memo.ContainsKey(input))
        {
            return memo[input];
        }

        int result = fib(input - 1, memo) + fib(input - 2, memo);
        memo[input] = result;
        return result;
    }

    public static int trib(int input, Dictionary<int, int> memo)
    {
        if (input == 0 || input == 1)
        {
            memo[input] = 0;
            return 0;
        }

        else if (input == 2)
        {
            memo[input] = 1;
            return 1;
        }

        if (memo.ContainsKey(input))
        {
            return memo[input];
        }

        int result = trib(input - 1, memo) + trib(input - 2, memo) + trib(input - 3, memo);
        memo[input] = result;
        return result;
    }
}