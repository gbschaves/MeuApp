// See https://aka.ms/new-console-template for more information
using System;

namespace MeuApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Product Mouse = new Product(1, "Mouse Gamer", 29);

      Console.WriteLine(Mouse.Id);
      Console.WriteLine(Mouse.Name);
      Console.WriteLine(Mouse.Price);
      Console.WriteLine("Teste de sincronia com git");
      
      Product Teclado = new Product(2, "Teclado", 50);
    }
  }

  struct Product
      {
        public Product(int id, string name, double price)
        {
          Id = id;
          Name = name;
          Price = price;
        }
        
        public int Id;
        public string Name;
        public double Price;
        
        public double PriceInDolar(double dolar)
        {
          return Price * dolar;
        }
      }

}
