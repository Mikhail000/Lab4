using System;

namespace Lab4
{
    class Camshaft : Unit
    {
        public Camshaft(string name = "Default", decimal weight = 10, int quantity = 1) 
            : base("Camshaft:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Camshaft work");
        }
    }
}
