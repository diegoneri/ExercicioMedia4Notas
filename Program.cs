using System;

namespace ExercicioMedia4Notas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      Decimal nota1, nota2, nota3, nota4;

      Console.WriteLine("- - - Média - - -\n");

      Console.WriteLine("Digite suas notas.");

      Console.Write("\nNota 1: ");
      nota1 = Convert.ToDecimal(Console.ReadLine());

      Console.Write("Nota 2: ");
      nota2 = Convert.ToDecimal(Console.ReadLine());

      Console.Write("Nota 3: ");
      nota3 = Convert.ToDecimal(Console.ReadLine());

      Console.Write("Nota 4: ");
      nota4 = Convert.ToDecimal(Console.ReadLine());

      Decimal Media = MediaConta(nota1, nota2, nota3, nota4);
    
        Console.WriteLine("");

      if (nota1 < 0 || nota2 < 0 || nota3 < 0 || nota4 < 0 ||
          nota1 > 10 || nota2 > 10 || nota3 > 10 || nota4 > 10)
      {
        Console.WriteLine("Digite um numero entre 0 e 10.");
        Environment.Exit(-1);
      }

      if (Media >= 6)
      {
        Console.WriteLine($"Você ficou com Media: {Media:N1} // Resultado.: Aprovado.");
      }

      if (Media >= 5 && Media < 6)
      {
        Console.WriteLine($"Você ficou com Media: {Media:N1} // Resultado.: Recuperação.");
      }
      
      if (Media <= 4)
      {
        Console.WriteLine($"Você ficou com Media: {Media:N1} // Resultado.: Reprovado.");
      }

      Console.WriteLine("\nObrigado por utilizar o programa!");

    }
    static Decimal MediaConta(Decimal N1, Decimal N2, Decimal N3, Decimal N4)
    {
      Decimal M = (N1 + N2 + N3 + N4) / 4;
      return M;
    }

  }
}


