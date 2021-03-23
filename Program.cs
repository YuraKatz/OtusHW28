using System;

namespace OtusHW28
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            var fish = new Fish(true, "animal2");
            var val = fish.CloneV2();
            Console.WriteLine($"Original Item :{ Environment.NewLine}{fish}");
            Console.WriteLine($"Cloned Item1 :{ Environment.NewLine}{val}");



            //var animal = new Animal("animal");

            //Console.WriteLine($"Original Item :{ Environment.NewLine}{animal}");
            //Console.WriteLine($"Cloned Item1 :{ Environment.NewLine}{animal.CloneV2()}");


            //var fish = new Fish(true, "animal2");

            //Console.WriteLine($"Original Item :{ Environment.NewLine}{fish}");
            //Console.WriteLine($"Cloned Item1 :{ Environment.NewLine}{fish.CloneV2()}");



            //var goldfish = new GoldFish(3, "animal3");

            //Console.WriteLine($"Original Item :{ Environment.NewLine}{goldfish}");
            //Console.WriteLine($"Cloned Item1 :{ Environment.NewLine}{goldfish.CloneV2()}");




            Console.ReadLine();
        }

      
    }
}