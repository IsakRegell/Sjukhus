// Avdelning.cs
public class Avdelning
{
    // Egenskap för att hålla avdelningsnamnet
    public string Namn { get; set; }

    // Konstruktor för att sätta namnet vid skapande av objektet
    public Avdelning(string namn)
    {
        Namn = namn;
    }
}
