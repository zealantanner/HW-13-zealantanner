using System;

public readonly struct Fraction
{
    private readonly int num, den;

    public Fraction(int numerator, int denominator)
    {
        num = numerator;
        den = denominator;
    }

    public static Fraction operator +(Fraction a, Fraction b)
        => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);

    public static Fraction operator -(Fraction a, Fraction b)
        => new Fraction(a.num * b.den - b.num * a.den, a.den * b.den);

    public static Fraction operator *(Fraction a, Fraction b)
        => new Fraction(a.num * b.num, a.den * b.den);

    public static Fraction operator /(Fraction a, Fraction b)
        => new Fraction(a.num * b.den, a.den * b.num);


    public static Fraction operator %(Fraction a, Fraction b)
        => new Fraction((a.num * b.den) % (b.num * a.den), a.den * b.den);


    public override string ToString() => $"{num} / {den}";
}

public static class OperatorOverloading
{
    public static void Main()
    {
        var a = new Fraction(5, 4);
        var b = new Fraction(2, 3);
        var c = new Fraction(5, 7);
        Console.WriteLine(a + b);
        Console.WriteLine(c - a);
        Console.WriteLine(b * c);
        Console.WriteLine(a / b);

        Console.WriteLine(a % b);
    }
}