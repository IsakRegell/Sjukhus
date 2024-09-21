
namespace ConsoleApp2
{
    public class Läkare
    {

        public string Name;
        public int Age;

         public Läkare(string name, int age)
        {
            Name = name;
            Age = age;
        }
       

            public void Bokatid()
        {
            Console.WriteLine("boka tid");
        }

        public void Avbokatid()
        {
            Console.WriteLine("avbokaboka tid");
        }

        public void Medicinjornal()
        {
            Console.WriteLine("Titta i patients medicinjornalen");
        }




        public virtual void LäkareInfo()
        {
            Console.WriteLine("Läkarens namn är " + Name + "Läkarens ålder är " + Age);
        }
    }
}
