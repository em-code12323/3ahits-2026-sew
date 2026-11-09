// ------------------------------
// Uebung_3_1
// ------------------------------

namespace Uebung_3_1;
using System;
using System.Reflection;

public class Complex {
    private readonly double re;   // Realteil
    private readonly double im;   // Imaginärteil

    public Complex(double real, double imag) {
        re=real;
        im=imag;
    }

    public override string ToString() {
        
        throw new NotImplementedException();
    }

    public double Abs() {
        int abs=Math.Sqrt(re*re+im*im);
        throw new NotImplementedException();
    }

    public Complex Plus(Complex b) {
        return new Complex(re + b.re,im + b.im);
      
    }

    public Complex Times(Complex b) {
        return new Complex((re *b.re - (im*b.im)) +((re*b.im)+(im*b.re)));
        
        throw new NotImplementedException();
    }


}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
