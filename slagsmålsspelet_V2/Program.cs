using System;

int P1HP = 100;

int P2HP = 100;

 
Console.WriteLine("P1 chose your name");
string name = Console.ReadLine();

Console.WriteLine("P2 now chose your name");
string name2 = Console.ReadLine();

Console.WriteLine(name + " choose your weapon. Spoon or bottle opener?");
string weapon = Console.ReadLine();
weapon = weapon.ToLower();

Console.WriteLine(name2 + " choose your weapon. Rubber duck or bowl.");
string weapon2 = Console.ReadLine();
weapon2 = weapon2.ToLower();


Console.WriteLine(name + " HP: " + P1HP); 
Console.WriteLine(name2 + " HP: " + P2HP);
Console.WriteLine("Press Enter To Atack");
Console.ReadLine(); 


if (weapon == "spoon" && weapon2 == "rubber duck")
{
while (P1HP >= 0 && P2HP >= 0)
{
    Random generator = new Random();

    int damage = generator.Next(20, 30);
    int damage2 = generator.Next(10, 20);

    P1HP = P1HP-damage2;
    P2HP= P2HP-damage;

    Console.WriteLine(name + " HP: " + P1HP + ". Does " + damage + " points of damage on " + name2);
    Console.WriteLine(name2 + " HP: " + P2HP + ". Does " + damage2 + " points of damage on " + name);
    Console.WriteLine("Press Enter To Atack Again");

    Console.ReadLine();
}
}

if(weapon == "bottle opener" && weapon2 == "bowl")
{
while (P1HP >= 0 && P2HP >= 0)
{
    Random generator = new Random();

    int damage = generator.Next(10, 20);
    int damage2 = generator.Next(20, 30);

    P1HP = P1HP-damage2;
    P2HP= P2HP-damage;

    Console.WriteLine(name + " HP: " + P1HP + ". Does " + damage + " points of damage on " + name2);
    Console.WriteLine(name2 + " HP: " + P2HP + ". Does " + damage2 + " points of damage on " + name);
    Console.WriteLine("Press Enter To Atack Again");

    Console.ReadLine();
}
}

if(weapon == "bottle opener" && weapon2 == "rubber duck")
{
while (P1HP >= 0 && P2HP >= 0)
{
    Random generator = new Random();

    int damage = generator.Next(10, 20);
    int damage2 = generator.Next(10, 20);

    P1HP = P1HP-damage2;
    P2HP= P2HP-damage;

    Console.WriteLine(name + " HP: " + P1HP + ". Does " + damage + " points of damage on " + name2);
    Console.WriteLine(name2 + " HP: " + P2HP + ". Does " + damage2 + " points of damage on " + name);
    Console.WriteLine("Press Enter To Atack Again");

    Console.ReadLine();
}
}

if(weapon == "spoon" && weapon2 == "bowl")
{
while (P1HP >= 0 && P2HP >= 0)
{
    Random generator = new Random();

    int damage = generator.Next(20, 30);
    int damage2 = generator.Next(20, 30);

    P1HP = P1HP-damage2;
    P2HP= P2HP-damage;

    Console.WriteLine(name + " HP: " + P1HP + ". Does " + damage + " points of damage on " + name2);
    Console.WriteLine(name2 + " HP: " + P2HP + ". Does " + damage2 + " points of damage on " + name);
    Console.WriteLine("Press Enter To Atack Again");

    Console.ReadLine();
}
}
//else
//{
//Console.WriteLine(name + " you still have to choose your weapon. Spoon or bottle opener?");
//Console.WriteLine(name2 + " you too. Rubber duck or bowl.");
//}

if (P1HP <= 0 && P2HP <= 0)
{
    Console.WriteLine("DRAW, BOTH HAS DIED!!!");
}

else if (P1HP <= 0)
{
    Console.WriteLine("KO!!! " + name2 + " has beaten " + name + "!");
}
else if (P2HP <= 0)
{
    Console.WriteLine("KO!!!" + name + " has beaten " + name2 + "!");
}

Console.ReadLine(); 