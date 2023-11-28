using System;

namespace Dziedziczenie
{
    // interfejs do wyświetlania informacji
    public interface IWyswietlalny
    {
        void WyswietlInformacje();
    }

    // klasa bazowa
    public class Specyfikacja : IWyswietlalny
    {
        protected string KategoriaPojazdu;
        protected double WagaPojazazdu;
        protected double PojemnoscSilnika;
        protected double MocSilnika;
        protected string KolorNadwozia;
        protected double IloscOsi;

        public Specyfikacja(string kp, double wp, double ps, double ms, string kn, double io)
        {
            KategoriaPojazdu = kp;
            WagaPojazazdu = wp;
            PojemnoscSilnika = ps;
            MocSilnika = ms;
            KolorNadwozia = kn;
            IloscOsi = io;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Kategoria pojazdu: " + KategoriaPojazdu);
            Console.WriteLine("Waga pojazdu w tonach: " + WagaPojazazdu);
            Console.WriteLine("Pojemność silnika: " + PojemnoscSilnika + "cm^3");
        }
    }

    // klasa pochodna
    public class Samochod : Specyfikacja, IWyswietlalny
    {
        public Samochod(string kp, double wp, double ps, double ms, string kn, double io) : base(kp, wp, ps, ms, kn, io)
        {
        }

        public new void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine("Moc silnika: " + MocSilnika + "KM");
            Console.WriteLine("Kolor nadwozia: " + KolorNadwozia);
            Console.WriteLine("Ilość osi: " + IloscOsi);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IWyswietlalny tp = new Samochod("Terenowy", 1.8, 1600, 114, "Czerwony", 2);
            tp.WyswietlInformacje();
        }
    }
}
