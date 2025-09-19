/*
 * 7    Skriv ett program som läser in ett tal n. Sedan läser det in yttrligare n tal och 
 *      beräknar och skriver deras summa.
 */

Console.Write("Hur många tal vill du summera? ");
int numberCount = int.Parse(Console.ReadLine());

long sumOfNumbers = 0;

for (int i = 0; i < numberCount; i++)
{
    Console.Write("{0}: ", i + 1);
    int number = int.Parse(Console.ReadLine());
    sumOfNumbers = sumOfNumbers + number;
}

Console.WriteLine("\nSumman av talen: {0}", sumOfNumbers);




Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
