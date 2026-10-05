// ------------------------------
// Uebung_2_2
// ------------------------------

using System.Net.Quic;

namespace Uebung_2_2;

class Rechteck
{
    double A;
    double B;

    public Rechteck(double a, double b)
    {
        A = a;
        B = b;
    }

    public Rechteck() : this(10, 20)
    {
    }

    public override string ToString()
    {
        return $" Seite A = {A}  Seite B = {B}";
    }
    public void resize()
    {
        if (A < B)
        {
            B = B - A;
        }
        else if (A > B)
        {
            A = A - B;


        }

    }
    public void inflate(double p)
    {
        A = A * (1 + p / 100);
        B = B * (1 + p / 100);


    }
    public double Aspect_Ratio()
    {
        return A / B;

    }
    public void setmaxside(double C)
    {
        
    }


}

class Program
{
    static void Main(string[] args)
    {

        Rechteck RE = new Rechteck();

        Console.WriteLine(RE);
        RE.resize();
        Console.WriteLine(RE);

        RE.inflate(50);
        Console.WriteLine(RE);
          Console.WriteLine(RE.Aspect_Ratio());
          
          


    }
}