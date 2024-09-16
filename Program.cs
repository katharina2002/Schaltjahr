/*
 * Schaltjahr ermitteln
 */

Console.WriteLine("Gebe ein Jahr ein");

int jahr = Convert.ToInt32(Console.ReadLine());
if (jahr % 4 == 0)
{
    if (jahr % 100 == 0)
    {
        if (jahr % 400 == 0)
        {
            Console.WriteLine($"{jahr} ist ein Schaltjahr");
        }
        else
        {
            Console.WriteLine($"{jahr} ist kein Schaltjahr");
        }
    }
    else
    {
        Console.WriteLine($"{jahr} ist ein Schaltjahr");
    }
}
else
{
    Console.WriteLine($"{jahr} ist kein Schaltjahr");
}
