using System;

namespace Lab4
{
    class Transmission : Unit
    {
        public Transmission(string name = "Default", decimal weight = 18, int quantity = 1) 
            : base("Transmission:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Transmission work");
        }
    }
}
