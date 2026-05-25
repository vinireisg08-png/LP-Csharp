using System;
public class Exercício6
{
    public static void Main(string[] args)
    {
        int diaSemana = 15;

        switch (diaSemana)
        {
            case 1:
                Console.WriteLine("Segunda-Feira");
                break;

            case 2:
                Console.WriteLine("Terça-Feira");
                break;

            case 3:
                Console.WriteLine("Quarta-Feira");
                break;

            case 4:
                Console.WriteLine("Quinta-Feira");
                break;

            case 5:
                Console.WriteLine("Sexta-Feira");
                break;

            case 6:
                Console.WriteLine("Sábado");
                break;

            case 7:
                Console.WriteLine("Domingo");
                break;

            default:
                Console.WriteLine("Número invalido");
                break;
        }
    }
}
                
                