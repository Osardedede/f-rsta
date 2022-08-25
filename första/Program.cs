using System;

Random generator = new Random();
int dd = generator.Next(1, 100);
int s = generator.Next(1, 100);
string svar;
int damage;
int damage2;
s1 s1 = new s1();
Enemy e1 = new Enemy();

while (s1.health > 0 && e1.health > 0)
{

    Console.WriteLine("kick or punch?");

    svar = Console.ReadLine();
    damage = s1.styrka - s;
    damage2 = e1.styrka - dd;
    e1.health = e1.health - damage;
    Console.WriteLine($"now the enemy has {e1.health}health left!");

    Console.WriteLine("He is hitting back");

    s1.health = s1.health - damage2;

    Console.WriteLine($"now you  has {(s1.health)} health left!");

}

if (s1.health < 0)
{
    Console.WriteLine("YOU LOSE");
}

if (e1.health < 0)
{
    Console.WriteLine("YOU WIN");
}

Console.WriteLine("PRESS ENTER TO CLOSE");
Console.ReadLine();


