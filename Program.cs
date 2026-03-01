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

            int jogador = int.Parse(Console.ReadLine());

            Random random = new Random();
            int computador = random.Next(1,4);

            Console.WriteLine($"o Computador escolheu {computador}");

            if(jogador == computador)
            {
                Console.WriteLine("empate");
            }
            else if (
                (jogador == 1 && computador  == 3) ||
                (jogador == 2 && computador == 1) ||
                (jogador == 3 && computador == 2)
            )
            {
                Console.WriteLine("você venceu");
            }
            else
            {
                Console.WriteLine("Você perdeu");
            }
        }
    }
}