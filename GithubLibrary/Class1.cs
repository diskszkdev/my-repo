namespace GithubLibrary;

public class Class1
{
    public string GetHelloWorld()
    {
        return "Hello World!";
    }

    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int _warmMethod()
    {
        return 0;
    }
}

public class demo : Exception
{
    public static void Initialize(int size) { }
    protected static readonly int _item;
    public static int item { get { return _item; } }
}