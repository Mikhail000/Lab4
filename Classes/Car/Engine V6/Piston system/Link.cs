using System;

namespace Lab4
{
    class Link : Unit
    {
        public Link(string name = "Default", decimal weight = 8, int quantity = 1) 
            : base("Link:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Link work");
        }
    }
}
