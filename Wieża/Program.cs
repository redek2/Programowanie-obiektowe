using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę krążków: ");
        int n = int.Parse(Console.ReadLine());

        Hanoi(n, 'A', 'C', 'B');

        Console.ReadKey();
    }

    static void Hanoi(int n, char pjeden, char ptrzy, char pdwa)
    {
        if (n > 0)
        {
            Hanoi(n - 1, pjeden, pdwa, ptrzy);

            Console.WriteLine($"Przenieś krążek {n} z {pjeden} na {ptrzy}");

            Hanoi(n - 1, pdwa, ptrzy, pjeden);
        }
    }
}
