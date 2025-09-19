/*
 * 9    Skriv ett program som skriver ut de första 100 talen i 
 *      Fibonacciserien: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89,...
 *      Tips: https://sv.wikipedia.org/wiki/Fibonaccital
 */

using System.Numerics;

BigInteger first = 0;
BigInteger second = 1;
BigInteger third = 0;

Console.WriteLine("De första 100 talen i Fibonacciserien:\n");
for (int i = 0; i < 100; i++)
{
    Console.Write(third + ", ");
    first = second;
    second = third;
    third = first + second;
}


Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
