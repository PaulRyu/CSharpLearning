using ConsoleApp1.Characters.Warriors;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(10, 100, "Barnabas");

        Warrior theBadGuy = new Warrior(100, 500, "Chad");

        Console.WriteLine(theGoodGuy.Height);
        Console.WriteLine(theBadGuy.Height);

        theGoodGuy.Greetings(theBadGuy);
        theBadGuy.Greetings(theGoodGuy);
    }
}