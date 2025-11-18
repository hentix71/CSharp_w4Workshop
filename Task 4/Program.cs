using Task4;

namespace Test4;

class Program
{
    public static void Main(string[] args)
    {
        Player player1 = new Player();
        Player player2 = new Player("Ayush", 21, 3071);

        Console.WriteLine(player1.playerName);
        Console.WriteLine(player1.level);
        Console.WriteLine(player1.health);

        Console.WriteLine(player2.playerName);
        Console.WriteLine(player2.level);
        Console.WriteLine(player2.health);

        
    }
}