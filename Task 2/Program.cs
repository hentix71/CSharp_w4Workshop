namespace Task2;

class Program
{
    public static void Main(string[] args)
    {
        Calculator obj = new Calculator();
        Console.Write("Eeter Numbers:");
        float a = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter For B: ");
        float b = Convert.ToSingle(Console.ReadLine());

        obj.PrintWelcome();
        Console.WriteLine($"The sum is {obj.Add(a,b)} and the Multiply is {obj.Multiply(a, b)}");
    }
}