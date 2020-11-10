using System;

namespace Lab4
{
    class Crankshaft : Unit
    {
        public Crankshaft(string name = "Default", decimal weight = 6, int quantity = 1) 
            : base("Crankshaft:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Crankshaft");
        }
    }
}
