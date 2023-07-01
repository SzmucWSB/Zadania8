using System;

struct Student
{
    public int NumerIndeksu;
    public string Imie;
    public string Nazwisko;
    public int Wiek;
    public string Kierunek;
    public float SredniaOcen;
}

struct Przedmiot
{
    public int NumerPrzedmiotu;
    public string NazwaPrzedmiotu;
    public string Prowadzący;
    public int GodzinyPrzedmiotu;
    public string Wydzial;
    public int LiczbaEtcs;
}

struct Nauczyciel
{
    public int NumerNauczyciela;
    public string Imie;
    public string Nazwisko;
    public string Wydzial;
    public string Tytul;
}
public class Program
{
    public static void Main()
    {
        Student student1;
        student1.NumerIndeksu = 11111;
        student1.Imie = "Jan";
        student1.Nazwisko = "Robak";
        student1.Wiek = 22;
        student1.Kierunek = "Teologia";
        student1.SredniaOcen = 3.8f;

        Przedmiot przedmiot1;
        przedmiot1.NumerPrzedmiotu = 27;
        przedmiot1.NazwaPrzedmiotu = "Podstawy programowania";
        przedmiot1.Prowadzący = "Dr. Aleksander Fredro";
        przedmiot1.GodzinyPrzedmiotu = 20;
        przedmiot1.Wydzial = "Wydział Elektryczny";
        przedmiot1.LiczbaEtcs = 7;

        Nauczyciel nauczyciel1;
        nauczyciel1.NumerNauczyciela = 777;
        nauczyciel1.Imie = "Jan";
        nauczyciel1.Nazwisko = "Hetman";
        nauczyciel1.Wydzial = "Wydział Rolnictwa";
        nauczyciel1.Tytul = "Doktor";

        Console.WriteLine("Informacje o studencie:");
        Console.WriteLine("Numer indeksu: " + student1.NumerIndeksu);
        Console.WriteLine("Imię i nazwisko: " + student1.Imie + " " + student1.Nazwisko);
        Console.WriteLine("Wiek: " + student1.Wiek);
        Console.WriteLine("Kierunek: " + student1.Kierunek);
        Console.WriteLine("Średnia ocen: " + student1.SredniaOcen);
        Console.WriteLine();
        Console.WriteLine("Informacje o przedmiocie:");
        Console.WriteLine("Numer przedmiotu: " + przedmiot1.NumerPrzedmiotu);
        Console.WriteLine("Nazwa przedmiotu: " + przedmiot1.NazwaPrzedmiotu);
        Console.WriteLine("Prowadzący: " + przedmiot1.Prowadzący);
        Console.WriteLine("Godziny przedmiotu: " + przedmiot1.GodzinyPrzedmiotu);
        Console.WriteLine("Wydział: " + przedmiot1.Wydzial);
        Console.WriteLine("Liczba ETCS: " + przedmiot1.LiczbaEtcs);
        Console.WriteLine();
        Console.WriteLine("Informacje o nauczycielu akademickim:");
        Console.WriteLine("Numer nauczyciela: " + nauczyciel1.NumerNauczyciela);
        Console.WriteLine("Imię i nazwisko: " + nauczyciel1.Imie + " " + nauczyciel1.Nazwisko);
        Console.WriteLine("Wydział: " + nauczyciel1.Wydzial);
        Console.WriteLine("Tytuł: " + nauczyciel1.Tytul);

        Console.ReadLine();
    }
}