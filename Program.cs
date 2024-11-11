int Dyljina = 0;
Console.WriteLine("Въведете символ за страните");
string symbol = Console.ReadLine();
string _ = " ";
Console.WriteLine("Въведете дължина на страните:");
Dyljina = Convert.ToInt32(Console.ReadLine());
for (int x = 0; x < Dyljina; x++)
{
    Console.Write(_);
    for (int y = 0; y < Dyljina - x - 1; y++)
    {
        Console.Write(_);
    }
    Console.Write(symbol);
    if (x > 0)
    {
        for (int z = 0; z < x -1; z++)
        {
            Console.Write(_);
        }
        Console.Write(symbol);
    }
    Console.WriteLine();
}
for (int b = 0; b < Dyljina +1; b++)
{
    Console.Write(symbol);
}

