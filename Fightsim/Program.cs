
int GoblinHp = 100;
int HumanHp = 100;

string GoblinName = "Goblin";
string HumanName = "Human";

while (GoblinHp > 0 && HumanHp > 0)
{
    Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
    Console.WriteLine($"{GoblinName}: {GoblinHp}  {HumanName}: {HumanHp}\n");

    int GoblinDamage = Random.Shared.Next(40);

    HumanHp -= GoblinDamage;
    HumanHp = Math.Max(0, HumanHp);

    Console.WriteLine($"{GoblinName} gör {GoblinDamage} skada på {HumanName}");

    int HumanDamage = Random.Shared.Next(30);

    GoblinHp -= HumanDamage;
    GoblinHp = Math.Max(0, GoblinHp);

    Console.WriteLine($"{HumanName} gör {HumanDamage} skada på {GoblinName}");

    Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
    Console.ReadKey();
}
Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");
if (GoblinHp == 0 && HumanHp == 0)
{
    Console.WriteLine("OAVGJORT");
}
else if (GoblinHp == 0)
{
    Console.WriteLine($"{HumanName} vann!");
}
else
{
     Console.WriteLine($"{GoblinName} vann!");
}

    Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();

