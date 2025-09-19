/*
 * 6    Skriv ett program som läser in koefficienterna a, b och c för 
 *      en andragradsekvation ax2 + bx + c = 0 och löser den (dvs skriver ut dess reella rötter)	
 *      Tips: https://sv.wikipedia.org/wiki/Andragradsekvation
 */

Console.WriteLine("Ange koefficienterna för andragradsekvationen -> a*x^2 + b * x + c = 0\n");
Console.Write("   a: "); double a = double.Parse(Console.ReadLine());
Console.Write("   b: "); double b = double.Parse(Console.ReadLine());
Console.Write("   c: "); double c = double.Parse(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("\nx = {0}\n", -c / b);
}
else
{
    double discriminant = b * b - 4 * a * c;
    if (discriminant == 0)
    {
        Console.WriteLine("nx[1] = x[2] = {0}\n", -b / (2 * a));
    }
    else if (discriminant < 0)
    {
        Console.WriteLine("\nDet finns inga reella rötter!n");
    }
    else if (discriminant > 0)
    {
        Console.WriteLine("\nx[1] = {0}", (-b + Math.Sqrt(discriminant) / (2 * a)));
        Console.WriteLine("\nx[2] = {0}", (-b - Math.Sqrt(discriminant) / (2 * a)));
    }
}




Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();
