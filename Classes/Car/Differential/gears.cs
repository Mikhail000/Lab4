using System;

namespace Lab4
{
    class gears : Unit
    {
        public gears(string name = "Default", decimal weight = 2, int quantity = 1)
            : base("gears:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("gears work");
        }
    }
}
