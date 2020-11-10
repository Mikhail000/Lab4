using System;

namespace Lab4
{
    class Piston : Unit
    {
        public Piston(string name = "Default", decimal weight = 9, int quantity = 1) 
            : base("Piston:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Piston work");
        }
    }
}
