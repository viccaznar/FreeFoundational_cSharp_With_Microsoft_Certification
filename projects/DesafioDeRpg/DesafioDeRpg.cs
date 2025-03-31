int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = Random.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was demaged and lost {roll} health and has {monster} health");

    if (monster -= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was demaged and lost {roll} health and has {hero} health");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > 0 ? "Hero wins!" : "Monster wins!");