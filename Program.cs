Console.WriteLine ("Введите число х ");

int numberX = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine ("Введите число y ");

int numberY = Convert.ToInt32(Console.ReadLine ());

if (numberX == numberY)
{
    Console.WriteLine ("numberX = numberY");
}
else if (numberX > numberY)
{
    Console.WriteLine ("numberX = max, numberY = min");
}
else
{
Console.WriteLine ("numberY = max, numberX = min");
}

