using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Utils;

namespace hello_world
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      List<FoodItem> food = new List<FoodItem>{
        new Egg(2),
        new Sausage(5),
        new Tomato(10),
      };

      Console.WriteLine($"We have a total food of :\n{String.Join("\n", food.Select(f => $"- {f.count} {f.type}").ToList())}");
      Console.WriteLine("Cooking the food");
      Task.WaitAll(food.Select(f => f.cook()).ToArray());
      Console.WriteLine("All done");
    }
  }
}
