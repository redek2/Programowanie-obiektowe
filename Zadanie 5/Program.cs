public interface ITypSamolotu
{
    void WyswietlDane();
}

public class Samolot : ITypSamolotu
{
    double waga;
    int silnik;
    int iloscSilnikow;
    int iloscMiejsc;
    string typUsterzenia;

    public Samolot(double waga, int silnik, int iloscSilnikow, int iloscMiejsc, string typUsterzenia)
    {
        this.waga = waga;
        this.silnik = silnik;
        this.iloscSilnikow = iloscSilnikow;
        this.iloscMiejsc = iloscMiejsc;
        this.typUsterzenia = typUsterzenia;
    }

    public void WyswietlDane()
    {
        Console.WriteLine($"Waga: {waga}kg");
        Console.WriteLine($"Ilość cylindrów w silniku: {silnik}");
        Console.WriteLine($"Ilość silników: {iloscSilnikow}");
        Console.WriteLine($"Ilość miejsc: {iloscMiejsc}");
        Console.WriteLine($"Typ usterzenia: {typUsterzenia}");
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Samolot samolot = new Samolot(5000, 16, 2, 120, "centropłat");
            Console.WriteLine("Dane samolotu:");
            samolot.WyswietlDane();
        }
    }
}