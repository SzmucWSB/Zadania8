using System;

enum Plec
{
    Mezczyzna,
    Kobieta
}

struct Student
{
    public string nazwisko;
    public int numerAlbumu;
    public float ocena;
    public Plec plec;
}

class Program
{
    static void Main(string[] args)
    {
        Student[] studenci = new Student[5];

        for (int i = 0; i < studenci.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Wprowadź informacje dla studenta {i + 1}:");
            Console.WriteLine();
            WypelnijInformacjeStudenta(ref studenci[i]);
        }

        Console.WriteLine("\nGrupa studentów:");
        foreach (Student student in studenci)
        {
            WyswietlInformacjeStudenta(student);
        }

        float sredniaOcena = ObliczSredniaOcene(studenci);
        Console.WriteLine($"\nŚrednia ocena grupy: {sredniaOcena}");

        Console.ReadLine();
    }

    static void WypelnijInformacjeStudenta(ref Student student)
    {
        Console.Write("Nazwisko: ");
        student.nazwisko = Console.ReadLine();

        Console.Write("Numer albumu: ");
        int numerAlbumu;
        while (!int.TryParse(Console.ReadLine(), out numerAlbumu))
        {
            Console.WriteLine("Błędny numer albumu. Wprowadź liczbę całkowitą.");
        }
        student.numerAlbumu = numerAlbumu;

        Console.Write("Ocena: ");
        float ocena;
        while (!float.TryParse(Console.ReadLine(), out ocena) || ocena < 2.0f || ocena > 5.0f)
        {
            Console.WriteLine("Błędna ocena. Wprowadź liczbę z zakresu 2.0 - 5.0.");
        }
        student.ocena = ocena;

        Console.Write("Płeć (M/K): ");
        string plecInput = Console.ReadLine().ToLower();
        while (plecInput != "m" && plecInput != "k")
        {
            Console.WriteLine("Błędna płeć. Wprowadź 'M' lub 'K'.");
            plecInput = Console.ReadLine().ToLower();
        }
        student.plec = (plecInput == "m") ? Plec.Mezczyzna : Plec.Kobieta;

        Console.WriteLine();
    }

    static float ObliczSredniaOcene(Student[] studenci)
    {
        float suma = 0;
        foreach (Student student in studenci)
        {
            suma += student.ocena;
        }
        return suma / studenci.Length;
    }

    static void WyswietlInformacjeStudenta(Student student)
    {
        Console.WriteLine($"Nazwisko: {student.nazwisko}, Numer albumu: {student.numerAlbumu}, Ocena: {student.ocena}, Płeć: {student.plec}");
    }
}
