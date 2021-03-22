using System;

namespace OtusHW28
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var animal = new Animal("animal");
          
            Console.WriteLine($"Original Item :{ Environment.NewLine}{animal}");
            Console.WriteLine($"Cloned Item1 :{ Environment.NewLine}{animal.Clone()}");
            Console.WriteLine($"Cloned Item2 :{ Environment.NewLine}{animal.MyClone<Animal>()}");

            var fish = new Fish(true, "animal2");

            Console.WriteLine($"Original Item :{ Environment.NewLine}{fish}");
            Console.WriteLine($"Cloned Item1 :{ Environment.NewLine}{fish.Clone()}");
            Console.WriteLine($"Cloned Item2 :{ Environment.NewLine}{fish.MyClone<Fish>()}");


            var goldfish = new GoldFish(3, "animal3");

            Console.WriteLine($"Original Item :{ Environment.NewLine}{goldfish}");
            Console.WriteLine($"Cloned Item1 :{ Environment.NewLine}{goldfish.Clone()}");
            Console.WriteLine($"Cloned Item2 :{ Environment.NewLine}{goldfish.MyClone<GoldFish>()}");



            Console.ReadLine();
        }

      
    }
}