using System;

namespace ExercicioMedia4Notas
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Clear();

        Decimal nota1, nota2, nota3, nota4, Resultado;

        Console.WriteLine("- - - - Média - - - -\n");

        Console.WriteLine("Digite suas notas.");

        Console.Write("\nNota 1:");
        nota1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("\nNota 2:");
        nota2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("\nNota 3:");
        nota3 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("\nNota 4:");
        nota4 = Convert.ToDecimal(Console.ReadLine());

        Resultado = (nota1 + nota2 + nota3 + nota4) / 4;

        if (nota1 <= -1 || nota2 <= -1 || nota3 <= -1 || nota4 <= -1 || nota1 > 10 || nota2 > 10 || nota3 > 10 || nota4 > 10)
        {
            Console.WriteLine("\nDigite somente notas entre 0 e 10.");
            Environment.Exit(-1);
        }
        
        if (Resultado >= 5)
        {
         Console.WriteLine($"\nVocê ficou com média {Resultado}. Resultado.: Aprovado ");   
        }
        else
        {
         Console.WriteLine($"\nVocê ficou com média {Resultado}. Resultado.: Reprovado ");   
        }
        

        }
    }
}
