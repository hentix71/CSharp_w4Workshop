namespace Task1;

class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student("Ayush", 20, 3071);
        Student s2 = new Student("Spandan", 20, 3071);

        Console.WriteLine($"Name : {s1.name} Age : {s1.age} Id : {s1.id}");
        Console.WriteLine($"Name : {s2.name} Age : {s2.age} Id : {s2.id}");
    }
}