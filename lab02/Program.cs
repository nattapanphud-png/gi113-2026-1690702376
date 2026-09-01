/*
 * student ID : 1690702376
 * Nane       : Lab02
 * Section    : 129D
 * No.        : 99
 * Course     : GT113 Computer Programming (GI)
 */

namespace lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "kirin";
            char rank = 's';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            
            
            Console.WriteLine("===== Boss stayus: IN=====ITIAL ");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"crit muliplilier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();






        }
    }
}
