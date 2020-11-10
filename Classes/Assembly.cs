using System;
using System.Collections.Generic;

namespace Lab4
{
    class Assembly : MachinePart
    {
        private List<MachinePart> _children = new List<MachinePart>();

        public Assembly(string name, int quantity) : base(name)
        {
            _quantity = quantity;
        }

        protected override int _quantity { get; set; }

        protected override decimal _weight 
        {
            get 
            { 
                return _weight;
            }
            set 
            { 
                GetWeight(); 
            } 
        }
        public override void Add(MachinePart component)
        {
            _children.Add(component);
        }

        public override void Remove(MachinePart component)
        {
            _children.Remove(component);
        }
        public override decimal GetWeight()
        {
            decimal temp = 0;
            foreach (MachinePart component in _children)
            {
                temp += component.GetWeight();
            }
            return temp*_quantity;
        }
        public override int GetQuantityOfDetails()
        {
            int temp = 0;
            foreach (MachinePart component in _children)
            {
                temp += component.GetQuantityOfDetails();
            }
            return temp;
        }

        public override void Work()
        {           
            foreach (MachinePart component in _children)
            {
                component.Work();
            }           
        }

        public override void Display(int depth)
        {
            Console.WriteLine("\n" + new String(' ', depth) + 
                $"{_name} " +
                $"- Quantity: {_quantity} " +
                $"- Weight: {GetWeight()/_quantity} " +
                $"- Total weight:{GetWeight()}" +
                $"- Quantity of details:{GetQuantityOfDetails()}");

            foreach (MachinePart component in _children)
            {
                component.Display(depth + 8);
            }
        }
    }
}