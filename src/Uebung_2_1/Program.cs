// ------------------------------
// Uebung_2_1
// ------------------------------

namespace Uebung_2_1;

class Schulklasse
{
    public int Schueler_anzahl;
    public string Lehrer;

    public Schulklasse(int schuelerAnzahl, string lehrer)
    {
        Schueler_anzahl = schuelerAnzahl;
        Lehrer = lehrer;
        
    }
    public int dazu()
    {
        return Schueler_anzahl+1;
    }
    public int raus(int a)
    {
        return Schueler_anzahl-a;
    }

    public Schulklasse() : this(22, "strasser")
    {
    }

    public override string ToString()
    {
        return $"Schueler: {Schueler_anzahl} Klassevorstand: {Lehrer}";
    }
}

class Program
{
    static void Main(string[] args)
    {

        Schulklasse ahits = new Schulklasse(22, "Strasser");
        Console.WriteLine(ahits);
        Schulklasse sk = new Schulklasse();
        Console.WriteLine(sk);
        Console.WriteLine(ahits.dazu());
        Console.WriteLine(ahits.raus(3));
       


    }
}