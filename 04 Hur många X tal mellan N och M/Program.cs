/*
 * 4 Skriv ett program som läser två positiva heltal och skriver hur många tal p som finns 
 *  mellan dem som är jämnt delbara med 5. Exempel: p(17, 25) = 2
 */

Console.WriteLine("Ange två heltal:");
Console.Write("   Första talet: ");
int first = int.Parse(Console.ReadLine());

Console.Write("   Andra talet: ");
int second = int.Parse(Console.ReadLine());

if (first == second || (first < 5 && second < 5))
{
    Console.WriteLine("\nDet finns inga tal som är delbara med fem mellan {0} och {1}", first, second);
    return;
}
else if (first > second)
{
    int swap = first;
    first = second;
    second = swap;
}

Console.Write("\nTal som är delbara med 5 i intervallet [{0};{1}]: ", first, second);
for (int i = first; i <= second; i++)
{
    if (i % 5 == 0)
    {
        //TODO: Fixa avslutande kommatecken för second = 26
        Console.Write(i + (i < second ? ", " : "") );   // Inget kommatecken på slutet
    }
}

Console.WriteLine();



Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();