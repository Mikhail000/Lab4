using System;

namespace Lab4
{
    class Tire : Unit
    {
        public Tire(string name = "Default", decimal weight = 16, int quantity = 1) 
            : base("Tire:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Tire work");
        }
    }
}
