using System;

public enum KlasaRzadkosci
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

public enum TypPrzedmiotu
{
    Broń,
    Zbroja,
    Amulet,
    Pierścien,
    Hełm,
    Tarcza,
    Buty
}

public struct Przedmiot
{
    public float Waga;
    public int Wartość;
    public KlasaRzadkosci Rzadkość;
    public TypPrzedmiotu Typ;
    public string NazwaWlasna;

    public void Wypelnij(float waga, int wartosc, KlasaRzadkosci rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
    {
        Waga = waga;
        Wartość = wartosc;
        Rzadkość = rzadkosc;
        Typ = typ;
        NazwaWlasna = nazwaWlasna;
    }

    public void Wyswietl()
    {
        Console.WriteLine($"Nazwa: {NazwaWlasna}");
        Console.WriteLine($"Typ: {Typ}");
        Console.WriteLine($"Rzadkość: {Rzadkość}");
        Console.WriteLine($"Wartość: {Wartość}");
        Console.WriteLine($"Waga: {Waga}");
    }
}

public class Program
{
    public static void Main()
    {

        Przedmiot[] skrzynia = new Przedmiot[4];

        WypelnijPrzedmiot(skrzynia, 0, 1.5f, 100, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Broń, "Miecz");
        WypelnijPrzedmiot(skrzynia, 1, 2.0f, 200, KlasaRzadkosci.Rzadki, TypPrzedmiotu.Zbroja, "Pancerz");
        WypelnijPrzedmiot(skrzynia, 2, 1.0f, 50, KlasaRzadkosci.Unikalny, TypPrzedmiotu.Amulet, "Amulet Mocy");
        WypelnijPrzedmiot(skrzynia, 3, 0.5f, 500, KlasaRzadkosci.Epicki, TypPrzedmiotu.Pierścien, "Pierscien Potęgi");

        Przedmiot losowyPrzedmiot = WylosujPrzedmiot(skrzynia);
        Console.WriteLine("Wylosowany przedmiot:");
        losowyPrzedmiot.Wyswietl();

        Console.ReadLine();
    }

    public static void WypelnijPrzedmiot(Przedmiot[] skrzynia, int indeks, float waga, int wartosc, KlasaRzadkosci rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
    {
        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Wypelnij(waga, wartosc, rzadkosc, typ, nazwaWlasna);
        skrzynia[indeks] = przedmiot;
    }

    public static Przedmiot WylosujPrzedmiot(Przedmiot[] skrzynia)
    {
        Random rand = new Random();
        int losowaRzadkosc = rand.Next(1, 11);

        KlasaRzadkosci rzadkosc;

        if (losowaRzadkosc <= 6)
            rzadkosc = KlasaRzadkosci.Powszechny;
        else if (losowaRzadkosc <= 9)
            rzadkosc = KlasaRzadkosci.Rzadki;
        else if (losowaRzadkosc <= 10)
            rzadkosc = KlasaRzadkosci.Unikalny;
        else
            rzadkosc = KlasaRzadkosci.Epicki;

        Przedmiot[] dostepnePrzedmioty = Array.FindAll(skrzynia, p => p.Rzadkość == rzadkosc);
        int losowyIndeks = rand.Next(0, dostepnePrzedmioty.Length);

        return dostepnePrzedmioty[losowyIndeks];
    }
}