using System;
public class Exercício6
{
    public static void Main(string[] args)
    {
        int nota = 100 ;
        switch (nota)
        {
            case int n when (nota >= 90):
                Console.WriteLine("Nota: A");
                break;
            case int n when (nota >= 80):
                Console.WriteLine("Nota: B");
                break;
            case int n when (nota >= 70):
                Console.WriteLine("Nota: C");
                break;
            case int n when (nota >= 60):
                Console.WriteLine("Nota: D");
                break;
            case int n when (nota < 60):
                Console.WriteLine("Reprovado");
                break;
            default:
                Console.WriteLine("Não existe nota");
                break;


        }
    }
}