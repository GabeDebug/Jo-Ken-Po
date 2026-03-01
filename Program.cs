using System;

namespace Jo_Ken_PO
{
    enum Escolhas
    {
        Pedra = 1,
        Papel = 2,
        Tisoura = 3
    }
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Escolha as opção: ");
            Console.WriteLine($"1 - Pedra ");
            Console.WriteLine("2 - Papel :");
            Console.WriteLine("3 - Tisoura :");
            Console.WriteLine("4 - Sair :");

            short v1 = short.Parse(Console.ReadLine());
        }
    }
}