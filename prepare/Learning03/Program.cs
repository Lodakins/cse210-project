using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction  fraction  = new Fraction();
        Fraction fraction_1 = new Fraction(10);
        Fraction fraction_2 = new Fraction(10,2);

        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
        
        Console.WriteLine(fraction_1.GetFractionString());
        Console.WriteLine(fraction_1.GetDecimalValue());

        Console.WriteLine(fraction_2.GetFractionString());
        Console.WriteLine(fraction_2.GetDecimalValue());
    }
    
}