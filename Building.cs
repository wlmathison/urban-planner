using System;

namespace urban_planner
{
    public class Building
    {
        public Building(string address)
        {
            _address = address;
        }

        private string _designer = "Billy Mathison";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address = "500 Interstate Blvd";
        private string _owner = "Billy Mathison";

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }

        public void List()
        {
            Console.WriteLine(_address);
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }
}