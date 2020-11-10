using System;

namespace Lab4
{
    class Radiator : Unit
    {
        public Radiator(string name = "Default", decimal weight = 14, int quantity = 1) 
            : base("Radiator:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Radiator");
        }
    }
}
