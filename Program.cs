using ConsoleApp2;
using System.Net.Cache;

class Program
{
    static void Main(string[] args)
    {
        // Skapar två avdelningar 
        Avdelning Del1 = new Avdelning("Kardologi");
        Avdelning Del2 = new Avdelning("Neurologi");

     
        // Skriver ut det första namnet
        Console.WriteLine("Första avdelningsnamnet är " + Del1.Namn);

        // Skriver ut det andra namnet
        Console.WriteLine("Andra avdelningsnamnet är " + Del2.Namn);


        Console.ReadKey();
    }
}

