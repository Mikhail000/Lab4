using System;

namespace Lab4
{
    class exhaustManifold : Unit
    {
        public exhaustManifold(string name = "Default", decimal weight = 12, int quantity = 1) 
            : base("exhaust manifold:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("exhaust manifold work");
        }
    }
}
