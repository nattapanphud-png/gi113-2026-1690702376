namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+--------------------+");
            Console.WriteLine("|     NEW ADVENTURE  |");
            Console.WriteLine("+--------------------+");
            Console.WriteLine("Name your hero");
            string PlayerName = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {PlayerName}. You jouruey begns..");

            Console.WriteLine("+--------------------+");
            Console.WriteLine("|  DIFFICULTY SELECT |");
            Console.WriteLine("+--------------------+");
            Console.WriteLine("Choos difficuty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nWelcome, {difficulty} selected God luck out There..");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

        }
    }
}
