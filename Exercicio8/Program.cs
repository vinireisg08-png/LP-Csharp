using System;
public class Exercício8
{
    public static void Main(string[] args)
    {
        int nota = 12;
        switch (nota)
        {
            case int n when (nota > 20 || nota < 0):
                Console.WriteLine("Nota inválida");
                break;
            case int n when (nota >= 17):
                Console.WriteLine("Excelente");
                break;
            case int n when (nota >= 14):
                Console.WriteLine("Boa");
                break;
            case int n when (nota >=10):
                Console.WriteLine("Suficiente");
                break;
            case int n when (nota <=9):
                Console.WriteLine("Insuficiente");
                break;
            default:
                Console.WriteLine("Nota inválida");
                break;


        }
    }
}
