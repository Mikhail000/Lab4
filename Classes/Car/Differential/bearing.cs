using System;

namespace Lab4
{
    class Bearing : Unit
    {
        public Bearing(string name = "Default",decimal weight = 1, int quantity = 1) 
            : base("Bearing:" + name, weight, quantity)
        {          
        }

        public override void Work()
        {
            Console.WriteLine("Bearing work");
        }
    }
}
