using System;
using System.Collections;
using System.Threading.Tasks;

namespace Utils
{
  class FoodItem
  {
    public int count { get; set; }
    public string type { get; set; }
    public FoodItem(int count)
    {
      this.count = count;
    }

    public Task cook()
    {
      return Task.Run(async () =>
      {
        Console.WriteLine($"Starting to cook {this.type}");
        await Task.Delay(new Random().Next(150, 4000));
        Console.WriteLine($"Cooked {this.GetType()}");
      });
    }
  }

  class Egg : FoodItem
  {
    public Egg(int count) : base(count)
    {
      this.type = count > 1 ? "Eggs" : "Egg";
    }
  }

  class Sausage : FoodItem
  {
    public Sausage(int count) : base(count)
    {
      this.type = count > 1 ? "Sausages" : "Sausage";
    }
  }

  class Tomato : FoodItem
  {
    public Tomato(int count) : base(count)
    {
      this.type = count > 1 ? "Tomatoes" : "Tomato";
    }
  }
}