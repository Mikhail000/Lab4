using System;

namespace Lab4
{
    class GasTank : Unit
    {
        public GasTank(string name = "Default", decimal weight = 17, int quantity = 1) 
            : base("Gas tank:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Gas tank work");
        }
    }
}
