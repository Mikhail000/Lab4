namespace Lab4
{
    abstract class MachinePart
    {
        protected string _name;

        protected abstract decimal _weight { get; set;}

        protected abstract int _quantity { get; set; }

        public MachinePart(string name)
        {
            this._name = name;           
        }      

        public abstract void Add(MachinePart c);

        public abstract void Remove(MachinePart c);

        public abstract decimal GetWeight();

        public abstract int GetQuantityOfDetails();

        public abstract void Work();

        public abstract void Display(int depth);
    }
}