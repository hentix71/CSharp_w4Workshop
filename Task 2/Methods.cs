namespace Task2;

class Calculator
{
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to Calculator");
    }
    public float Add(float a, float b)
    {
        return a + b;
    }

    public float Multiply(float a, float b=1)
    {
        return a * b;
    }
}