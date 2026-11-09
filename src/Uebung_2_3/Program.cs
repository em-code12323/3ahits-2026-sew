// ------------------------------
// Uebung_2_3
// ------------------------------

namespace Uebung_2_3;

class Bankkonto{
    
    double Kontostand;
    string Kontoinhaber;
    double Zinssatz;




 public override string ToString()
    {
        return $" Kontostand = {Kontostand}  Kontoinhaber = {Kontoinhaber} Zinsatz ={Zinssatz}";

    }

public Bankkonto(double kontostad,string kontoinhaber,double zinsatz)
    {
        Kontostand=kontostad;
        Kontoinhaber=kontoinhaber;
        Zinssatz=zinsatz;

    }

    public void  Ein(double Einzahlung )
    {
        Kontostand+=Einzahlung;

    }
    public void Aus(double Betrag)
    {
        Kontostand-=Betrag;
    }
    public double Jahresabschluss()
    {
      double zinsen=Kontostand*Zinssatz;
    Kontostand=Kontostand*(1+Zinssatz);
    return zinsen;

    }
}
class Program
{
    static void Main(string[] args)
    {
        Bankkonto meinKonto = new Bankkonto(1000.0, "Emran", 0.03);
        
        Console.WriteLine(meinKonto); 
       

        meinKonto.Einzahlen(500);
        meinKonto.Jahresabschluss();

        Console.WriteLine(meinKonto);
    }
}
