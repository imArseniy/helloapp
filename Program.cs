internal static class Program
{
    private static void Main()
    {
        Hello();
    }

    private static void Hello()
    {
        Console.WriteLine("hello everyone");
        GreetWhite();
        GreetBlack();
    }

    private static void GreetWhite()
    {
        Console.WriteLine("hello white");
    }

    private static void GreetBlack()
    {
        Console.WriteLine("hello black");
    }
}
