using System.Data;

Random random = new Random();

int manticoreHealth = 10;

int cityHealth = 15;

int manticoreDistance = random.Next(1, 101);

int round = 1;

while (manticoreHealth > 0 && cityHealth > 0)
{
    Console.ForegroundColor = ConsoleColor.White;   
    Console.WriteLine($"Manticore Health: {manticoreHealth} | City Health: {cityHealth} | Round: {round}");
    
    Console.Write("Distance to shoot: ");
    int cannonDistance = Convert.ToInt32(Console.ReadLine());

    if (ManticoreHitDetection(cannonDistance))
    {
        manticoreHealth -= CannonDamage();
        Console.WriteLine($"Damage done: {CannonDamage()}\n");
    }
    
    cityHealth -= 1;
    round++;
}
if (manticoreHealth <= 0) 
{
    Console.WriteLine("You win!");
    Console.WriteLine($"Manticore Health: 0 | City Health: {cityHealth} | Round: {round}");
    
}
else if (cityHealth <= 0)
{
    Console.WriteLine("You lose..");
    Console.WriteLine($"Manticore Health: {manticoreHealth} | City Health: 0 | Round: {round}");
    
}
Console.ReadKey();

bool ManticoreHitDetection(int cannonShot)
{
    
    if (cannonShot < manticoreDistance)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Too short!\n");
        return false;   
    }

    else if (cannonShot > manticoreDistance)
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Too far!\n");
        return false;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Direct Hit!");
        return true;
    }

}
int CannonDamage()
{
    if (round % 5 == 0 && round % 3 == 0)
    {
        return 10;  
    }
    else if (round % 5 == 0 || round % 3 == 0)
    {
        return 3;
    }
    else
    {
        return 1;
    }
}
