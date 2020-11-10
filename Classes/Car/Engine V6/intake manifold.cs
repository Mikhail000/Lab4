using System;

namespace Lab4
{
    class intakeManifold : Unit
    {
        public intakeManifold(string name = "Default", decimal weight = 13, int quantity = 1) 
            : base("intake manifold:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("intake manifold work");
        }
    }
}
