using System;

namespace Lab4
{
    class Glass : Unit
    {
        public Glass(string name = "Default", decimal weight = 5, int quantity = 1)
            : base("Glass:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Glass work");
        }
    }
}
