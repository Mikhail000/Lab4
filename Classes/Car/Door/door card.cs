using System;

namespace Lab4
{
    class doorCard : Unit
    {
        public doorCard(string name = "Default", decimal weight = 4,int quantity = 1) 
            : base("door card:" + name, weight, quantity)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Door card work");
        }
    }
}
