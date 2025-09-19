/*
 * 10   Skriv ett program som beräknar summan (med en noggrannhet av 0.001) av: 
 *      1 + ½ - 1/3 + ¼ - 1/5 + …
*/

decimal expression = 1;

Console.Write("1 ");
for (int nämnare = 2; nämnare <= 50; nämnare++)
{
    if (nämnare % 2 == 0)
    {
        Console.Write("+ 1/{0} ", nämnare);
        expression += 1m / nämnare;
    }
    else
    {
        Console.Write("- 1/{0} ", nämnare);
        expression -= 1m / nämnare;
    }
}

Console.WriteLine("= {0:F9}", expression);





Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
