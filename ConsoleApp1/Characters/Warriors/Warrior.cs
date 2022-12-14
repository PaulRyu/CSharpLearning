using ConsoleApp1.Weapons;

namespace ConsoleApp1.Characters.Warriors
{
    public class Warrior
    {
        private const int DEFAULT_HEIGHT = 100;
        private const int DEFAULT_WEIGHT = 100;
        private const int DEFAULT_AGE = 18;
        private const string DEFAULT_NAME = "Warrior";
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();

        public static int idCounter;

        private readonly int id;
        private int height;
        private int weight;
        private int age;
        private string name;
        private Sword swordWeapon;

        public static int IdCounter 
        {
            get
            {
                return Warrior.idCounter;
            } 
            private set
            {
                Warrior.idCounter = value;
            }
        }
        public int ID
        {
            get
            {
                return this.id;
            }
        }

        public int Age
        {
            get
            {

                return age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Improper age for Warrior: {name}");
                }
            }
        }
        protected internal int Height 
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public string Name 
        { 
            get
            {
                return name;
            } 
            set
            {
                name = value;
            }
        }
        public Sword SwordWeapon 
        { 
            get
            {
                return this.swordWeapon;
            } 
            set
            {
                this.swordWeapon = value;
            }
        }

        public Warrior()
            : this(DEFAULT_HEIGHT, DEFAULT_WEIGHT) // Calls constructor below it
        {
            //this.Name = "Warrior";
            //this.Age = 18;
            //this.SwordWeapon = new Sword(); // This code is run below because the rest of the constructor
                                              // code is executed as well
        }

        public Warrior(int height, int weight)
            : this(height, weight, DEFAULT_NAME)
        {
            //this.Height = height;
            //this.Weight = weight;
            //this.Name = "Warrior";
            //this.Age = 18;
            //this.SwordWeapon = new Sword();
        }

        public Warrior(int height, int weight, string name)
        {
            Warrior.IdCounter++;
            this.id = IdCounter;
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = DEFAULT_AGE;
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;
        }
        
        //Autogenerated with CTRL + . + ENTER
        //public Warrior(int height, int weight, int age, string name, Sword swordWeapon)
        //{
        //    this.height = height;
        //    this.weight = weight;
        //    this.age = age;
        //    this.name = name;
        //    this.swordWeapon = swordWeapon;
        //}

        public void Greetings(string name)
        {
            Console.WriteLine($@"{this.name}, greets {name}!");
        }

        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($"\nDefault Height: {DEFAULT_HEIGHT}" +
                $"\nDefault Weight: {DEFAULT_WEIGHT}" +
                $"\nDefault Name: {DEFAULT_NAME}" +
                $"\nDefault Age: {DEFAULT_AGE}" +
                $"\nDefault Weapon Damage: {warrior.DEFAULT_SWORD_WEAPON.Damage}");
        }
    }
}