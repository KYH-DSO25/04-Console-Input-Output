/*
 * 5    Skriv ett program som läser två tal från konsolen och skriver det största av dem. 
 * Gör det utan att använda en if-sats
 */

Console.WriteLine("Ange två heltal:");
Console.Write("   Första talet: ");
int first = int.Parse(Console.ReadLine());

Console.Write("   Andra talet: ");
int second = int.Parse(Console.ReadLine());

Console.WriteLine("\nDet största talet är: {0}\n", Math.Max(first, second));




Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
