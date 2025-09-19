namespace _03_Företagsinformation;
internal class Company
{
    public CManager manager;

    public string name;
    public string address;
    public string phoneNumber;
    public string faxNumber;
    public string webSite;

    // Metod för inmatning av data
    public void InputData()
    {
        Console.WriteLine("Ange information om ditt företag:");

        Console.Write("Företagsnamn: ");
        name = Console.ReadLine();

        Console.Write("Adress: ");
        address = Console.ReadLine();
        Console.Write("Telefonnummer: ");
        phoneNumber = Console.ReadLine();
        Console.Write("Faxnummer: ");
        faxNumber = Console.ReadLine();
        Console.Write("Hemsida: ");
        webSite = Console.ReadLine();
    }

    // Metod för att skriva ut data
    public void PrintInformation()
    {
        Console.WriteLine("\nInformation om förtaget \"{0}\": ", name);
        Console.WriteLine("\tFöretagsnamn: {0}", name);
        Console.WriteLine("\tAdress: {0}", address);
        Console.WriteLine("\tTelefonnummer: {0}", phoneNumber);
        Console.WriteLine("\tFaxnummer: {0}", faxNumber);
        Console.WriteLine("\tHemsida: {0}", webSite);
    }

    public class CManager
    {
        private string firstName;
        private string lastName;
        private byte age;
        private string phoneNumber;

    }
}
