using System;


public class Exercício12
{

    public static void Main(string[] args)
    {
        int soma = 0;
        int counter;

        for (counter = 0; soma <= 100; counter++)
        {
            soma += counter;
            Console.WriteLine(soma);
        }

        Console.WriteLine("ultimo número adicionado: " + counter);
    }
}
