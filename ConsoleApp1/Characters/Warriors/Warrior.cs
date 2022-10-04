namespace ConsoleApp1.Characters.Warriors
{
    public class Warrior
    {
        private int height;
        private int weight;
        private int age;
        private string name;

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
        public int Height 
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

        public Warrior(int height, int weight, string name)
        {
            this.height = height; // pointing to the height declared at the top of the class
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
        }
        public void Greetings(string name)
        {
            Console.WriteLine($@"{this.name}, greets {name}!");
        }
    }
}