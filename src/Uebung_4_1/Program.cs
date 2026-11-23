namespace Uebung_4_1;

class Program
{
    static void Main(string[] args)
    {
        string text = "abcdefghijk";
        Console.WriteLine(text.Length);

        Console.WriteLine("Hello, World!");

        string textEmran = "Emran";
        char buchstabe = textEmran[0];
        
        string wort1 = "fafh";
        string wort2 = "abcf";
        int ergebnis = wort1.CompareTo(wort2); 

        string textProg = "Programmierung";
        string teil = textProg.Substring(3, 8);
        
        string textHallo = "hallo wie gehts ";
        bool enthalt = textHallo.Contains("wie");
        
        string textBanana = "Banana";
        int ersterIndex = textBanana.IndexOf('a'); 
        int letzterIndex = textBanana.LastIndexOf('a'); 
        
        string datei = "dokument.pdf";
        bool beginnt = datei.StartsWith("dok"); 
        bool endet = datei.EndsWith(".pdf");
        
        string textGuten = "Guten Tag!";
        string neu = textGuten.Insert(6, "schönen "); 
        
        string zahl = "42";
        string linksGefuellt = zahl.PadLeft(5, '0'); 
        string rechtsGefuellt = zahl.PadRight(5, '.');
        
        string textSpaces = "   Hallo  ";
        string getrimmt = textSpaces.Trim();         
        string linksGetrimmt = textSpaces.TrimStart(); 
        string rechtsGetrimmt = textSpaces.TrimEnd();  
        
        string textProg2 = " Programmieren";
        string klein = textProg2.ToLower(); 
        string gross = textProg2.ToUpper();
    }

    public static string ReverseString(string input)
    {
        if (input == null) return null;
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}