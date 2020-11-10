using System;

namespace Lab4
{
    class Gasket : Unit
    {
        public Gasket(string name = "Gasket", decimal weight = 7, int quantity = 1) 
            : base("Gasket:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Gasket work");
        }
    }
}
