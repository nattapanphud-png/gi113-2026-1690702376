namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            namespace lad3
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                const int MaxLevel = 10;

                var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
                var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
                int level = 7;
                int maxHp = 240;
                int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
                float attackPower = 42.5f;
                double critMultiplier = 1.75;
                bool isBoss = true;
                Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
                Console.WriteLine($"Name: {bossName}");
                Console.WriteLine($"Rank: {rank}");
                Console.WriteLine($"Level {level} / {MaxLevel}" +
                    $"\nHP: {currentHp} / {maxHp}" +
                    $"\nAttack Power: {attackPower}" +
                    $"\nCrir Multiplier: {critMultiplier}" +
                    $"\nIs Boss: {isBoss}");


                Console.WriteLine("----- Implicit Conversion: HP as double -----");
                double CurrentHpDouble = currentHp;
                Console.WriteLine($"HP (double): {CurrentHpDouble}");






                Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
                double hpPercentExact = CurrentHpDouble * 100 / maxHp;
                Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");




                Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
                double castPower = (int)attackPower;
                Console.WriteLine($"Attack power(int cast): {castPower}");

                Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
                int castCrir = (int)critMultiplier;
                Console.WriteLine($"Crit Muliplier; (int cast): {castPowser}");
                Console.WriteLine("Crit Multiplier (Convert rounded): " + Convert.ToInt32(critMultiplier));



            }
        }
    }

}
    }
}
