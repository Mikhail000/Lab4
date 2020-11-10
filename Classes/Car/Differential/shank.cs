using System;

namespace Lab4
{
    class shank : Unit
    {
        public shank(string name = "Default", decimal weight = 3, int quantity = 1) 
            : base("shank:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("shank work");
        }
    }
}
