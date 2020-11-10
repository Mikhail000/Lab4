using System;

namespace Lab4
{
    class Unit : MachinePart
    {
        public Unit(string name, decimal weight,int quantity) : base(name)
        {
            _weight = weight;
            _quantity = quantity;
        }

        protected override int _quantity { get; set; }

        protected override decimal _weight { get; set; }
        public override void Add(MachinePart c)
        {
            Console.WriteLine("Cannot add to a Unit");
        }

        public override void Remove(MachinePart c)
        {
            Console.WriteLine("Cannot remove from a Unit");
        }
        public override decimal GetWeight()
        {
            return _weight*_quantity;
        }
        public override int GetQuantityOfDetails()
        {
            return _quantity;
        }

        public override void Work()
        {          
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String(' ', depth) + $"{_name} - Quantity: {_quantity} - Weight: {_weight} - Total weight: {GetWeight()}");
        }
    }
}