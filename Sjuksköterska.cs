
using System.Net.Cache;

namespace ConsoleApp2
{
    public class Sjuksöterska
    {
        public string Name;
        public int Age;

        public Sjuksöterska(string name, int age)
        {
            Name = name;
            Age = age;
        }
        

        public virtual void SjuksköterskaInfo()
        {
            Console.WriteLine("Sjuksköterskans namn är " + Name + "Sjuksötatens ålder är " + Age);
        }

        /*Vet ej hur jag ska få in metoderna 
         * TaHandOmPatient()
         * AssisteraLäkaren()
         */
    }
}
