using System;

namespace Lab4
{
    class Value : Unit
    {
        public Value(string name = "Default", decimal weight = 11, int quantity = 1) 
            : base("Value:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Value work");
        }
    }
}
