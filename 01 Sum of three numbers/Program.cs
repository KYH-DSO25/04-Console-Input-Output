/*
* 1. Skriv ett program som läser tre heltal från konsolen och 
* skriver ut deras summa
*/

Console.Write("Ange 3 heltal ->");
decimal[] numbers = new decimal[3];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Tal nummer {0}: ", i + 1);
    numbers[i] = decimal.Parse(Console.ReadLine());
}

Console.WriteLine("Summan av talen: {0}", numbers.Sum());



Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();