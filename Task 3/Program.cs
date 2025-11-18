namespace Task3;

class Program
{
    public static void Main(string[] args)
    {
        ParameterDemo obj = new ParameterDemo();
        int a = 100;
        obj.Increase(ref a);
        Console.WriteLine(a);

        string name;
        obj.GetFullName(out name);
        Console.WriteLine(name);

        float sumValue = obj.SumAll([1, 2, 3, 4, 5]);
        Console.WriteLine(sumValue);

    }
}