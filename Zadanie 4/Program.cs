class Program
{
    static void Main(string[] args)
    {
        List<Pracownik> lista = new List<Pracownik>();
        lista.Add(new Sekretarka());
        lista.Add(new Ochroniarz());
        lista.Add(new Ksiegowy());

        foreach (var i in lista)
        {
            i.Pracuj();
        }

        Console.ReadKey();
    }


    public class Pracownik
    {
        virtual public void Pracuj() { Console.WriteLine("Pracownik pracuje"); }
    }

    public class Sekretarka : Pracownik
    {
        public override void Pracuj() { Console.WriteLine("Sekretarka pracuje"); }
    }

    public class Ochroniarz : Pracownik
    {
        public override void Pracuj() { Console.WriteLine("Ochroniarz pracuje"); }
    }

    public class Ksiegowy : Pracownik
    {
        public override void Pracuj() { Console.WriteLine("Księgowy pracuje"); }
    }
}