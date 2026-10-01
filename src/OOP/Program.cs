// ------------------------------
// OOP
// ------------------------------

namespace OOP;


class Schule// = struc in c
{
    public string name; // member variable public member vs private member  
    public int anzahl_schueler; // member variable || Feld 
    public int anzahl_lehrer;
    // non static methode 
    public int anzahl_personen()
    {
        return anzahl_schueler + anzahl_lehrer;

    }

    //ToString() methode

    public override string ToString()
    {
        
         {
            return $"Schule: {name}, Schüler: {anzahl_schueler},Lehrer: {anzahl_lehrer}";


           }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Schule htl  /* Reference=pointer*/= new Schule(); // Objekt erstellen ( instanzieren)
        htl.name = "HTL Braunau";// member variable setzen 
        htl.anzahl_schueler = 1000;
        htl.anzahl_lehrer = 200;
        htl.anzahl_personen;
        Console.WriteLine($"Es besuchen {htl.anzahl_personen()} Personen die {htl.name}");



        // HLW 
        Schule hlw = new Schule();
        hlw.name = "HLW Braunau";
        hlw.anzahl_schueler = 600;
        hlw.anzahl_lehrer = 80;
        Console.WriteLine($"Es besuchen {hlw.anzahl_personen()} Personen die {hlw.name}");
        // ------------------
        int n=42;
        Console.WriteLine(n);
        Console.WriteLine(htl);











    }
}
