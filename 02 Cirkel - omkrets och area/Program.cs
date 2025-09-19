/*
 * 2 Skriv ett program som läser radien r för en cirkel och skriver ut dess omkrets och area
*/

Console.Write("Ange cirkelns radie: ");
double r = double.Parse(Console.ReadLine());

double omkrets = 2 * r * Math.PI;
double area = r * r * Math.PI;

Console.WriteLine("Omkrets: {0:F3}\nArea: {1:F6}", omkrets, area);




Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();