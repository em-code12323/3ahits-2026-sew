// ------------------------------
// Uebung_4_2
// ------------------------------

namespace Uebung_4_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        public static string ReverseString(string input)
    {
        if (input == null) return null;
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
        
    }
    }
}
