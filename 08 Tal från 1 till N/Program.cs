/*
 * 8    Skriv ett program som läser in ett heltal n och skriver ut alla heltal 
 *      i intervallet [1..n], vart och ett på en egen rad
 */

Console.Write("Ange ett tal (större än 1): ");
uint number = uint.Parse(Console.ReadLine());

Console.WriteLine("\nAlla tal i intervallet [1;{0}]: ", number);
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(i + (i < number ? ", " : "\n\n"));
}

Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
