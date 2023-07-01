using System;

public enum DniTygodnia
{
    Poniedzialek = 1,
    Wtorek = 2,
    Sroda = 3,
    Czwartek = 4,
    Piatek = 5,
    Sobota = 6,
    Niedziela = 7
}

public enum EtapyPrania
{
    Wypelnianie,
    Pranie,
    Plukanie,
    Wirowanie,
    Suszenie
}

public enum Posilek
{
    Sniadanie,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

public enum BierkaSzachowa
{
    Pionek,
    Wieza,
    Skoczek,
    Goniec,
    Hetman,
    Krol
}

public class Program
{
    public static void Main()
    {


        DniTygodnia dzien = DniTygodnia.Piatek;
        Console.WriteLine("Dzisiaj jest: " + dzien);

        EtapyPrania etap = EtapyPrania.Wirowanie;
        Console.WriteLine("Obecny etap prania: " + etap);

        Posilek posilek = Posilek.Kolacja;
        Console.WriteLine("Aktualny posiłek: " + posilek);

        BierkaSzachowa bierka = BierkaSzachowa.Hetman;
        Console.WriteLine("Wybrana bierka szachowa: " + bierka);

        Console.ReadLine();
    }
}