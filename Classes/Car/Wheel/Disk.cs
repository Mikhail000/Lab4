using System;

namespace Lab4
{
    class Disk : Unit
    {
        public Disk(string name = "Default", decimal weight = 15, int quantity = 1) 
            : base("Disk:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Disk work");
        }
    }
}
