using System;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Reflection;
public class Exercício10
{
    public static void Main(string[] args)
    {
        int soma = 0;
        for (int counter = 1; counter <= 50; counter++)
        {
            if (counter % 2 != 0)
            {
                soma += counter;
            }
           
        }
        Console.WriteLine(soma);
    }
}
