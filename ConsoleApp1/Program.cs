using ConsoleApp1.Characters.Warriors;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(10, 100, "Barnabas");

        Warrior theBadGuy = new Warrior(100, 500, "Chad");

        Console.WriteLine(theGoodGuy.Height);
        Console.WriteLine(theBadGuy.Height);
        try
        {
            theGoodGuy.Age = 25;
            theBadGuy.Age = 58;
        }
        catch(ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        Console.WriteLine(theGoodGuy.Age);
        Console.WriteLine(theBadGuy.Age);

        theGoodGuy.Greetings(theBadGuy);
        theBadGuy.Greetings(theGoodGuy);
    }
}