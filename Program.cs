// See https://aka.ms/new-console-template for more information
using System;

namespace MeuApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu(){
      Console.Clear();

      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Multiplicação");
      Console.WriteLine("4 - Media");
      Console.WriteLine("-------------------");
      Console.WriteLine("Selecione uma opção: ");

      short res = short.Parse(Console.ReadLine());

      switch(res){
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        default: Menu(); break;

      }
    }

    static void Soma()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());
     
     Console.WriteLine("");

     float resultado = v1 + v2;

    //  Console.WriteLine("O Resultado da soma é " + resultado);
     Console.WriteLine($"O resultado da soma é {resultado}");
    //  Console.WriteLine($"O resultado da soma é {v1 + v2}");
    //  Console.WriteLine("O resultado da soma é " + (v1 + v2));
     Console.ReadKey();
     Menu();
    }

    static void Subtracao() {
      Console.Clear();
      Console.WriteLine("Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());
     
     Console.WriteLine("");

     float resultado = v1 - v2;

     Console.WriteLine($"O resultado da soma é {resultado}");

     Console.ReadKey();

     Menu();
    }

    static void Divisao() {
      Console.Clear();
      Console.WriteLine("Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());
     
     Console.WriteLine("");

     float resultado = v1 / v2;

     Console.WriteLine($"O resultado da soma é {resultado}");

     Console.ReadKey();
     Menu();
    }

    static void Multiplicacao() {
      Console.Clear();
      Console.WriteLine("Primeiro Valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor: ");
      float v2 = float.Parse(Console.ReadLine());
     
     Console.WriteLine("");

     float resultado = v1 * v2;

     Console.WriteLine($"O resultado da soma é {resultado}");

     Console.ReadKey();
     Menu();
    }

  }


}
