using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("Digite um número ímpar: ");
        while (!int.TryParse(Console.ReadLine(), out num) || num % 2 == 0)
        {
            Console.Write("Por favor, digite um número ímpar: ");
        }

        // desenha a primeira metade do diamante
        for (int i = 0; i < num / 2; i++)
        {
            for (int j = 0; j < num; j++)
            {
                if (j >= num / 2 - i && j <= num / 2 + i)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        // desenha a linha do meio
        for (int j = 0; j < num; j++)
        {
            Console.Write("x");
        }
        Console.WriteLine();

        // desenha a segunda metade do diamante
        for (int i = num / 2 + 1; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                if (j >= i - num / 2 && j <= num - 1 - (i - num / 2))
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
