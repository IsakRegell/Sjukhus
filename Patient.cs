
namespace ConsoleApp2
{
    public class Patient
    {
        public string Name;
        public int Age;


        public Patient(string name, int age)
        {
            Name = name;
            Age = age;
        }



        public virtual void PatientInfo()
        {
            Console.WriteLine("Patientens namn är " + Name + "Patientens ålder är " + Age);
        }
    }
}
