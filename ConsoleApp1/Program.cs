using ConsoleApp1.Characters.Warriors;

public class EntryPoint
{
    static void Main()
    {
        Warrior firstWarrior = new Warrior();
        Warrior secondWarrior = new Warrior(150, 150);
        Warrior thirdWarrior = new Warrior(200, 200, "New Char");

        Console.WriteLine(firstWarrior.ID);
        Console.WriteLine(secondWarrior.ID);
        Console.WriteLine(thirdWarrior.ID);

        Warrior.GetDefaultValues(firstWarrior);
        //Warrior theGoodGuy = new Warrior(10, 100, "Barnabas");

        //Warrior theBadGuy = new Warrior(100, 500, "Chad");

        //Warrior youngWarrior = new Warrior(50, 80);

        //Console.WriteLine(theGoodGuy.Height);
        //Console.WriteLine(theBadGuy.Height);
        //try
        //{
        //    theGoodGuy.Age = 25;
        //    theBadGuy.Age = 58;
        //}
        //catch(ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        
        //Console.WriteLine(theGoodGuy.Age);
        //Console.WriteLine(theBadGuy.Age);

        //theGoodGuy.Greetings("Chad");

        //Console.WriteLine(theGoodGuy.SwordWeapon.Damage);
    }
}