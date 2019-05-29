using System;
using System.Collections.Generic;

namespace urban_planner
{
    public class City
    {
        public City(string name)
        {
            _name = name;
        }
        private string _name { get; set; }
        private string _mayor { get; set; }
        private string _established { get; set; }

        public List<Building> AllBuildings = new List<Building>();

        public void Founded(int year, int month, int day)
        {
            _established = new DateTime(year, month, day).ToShortDateString();
        }

        public void ElectMayor(string mayor)
        {
            _mayor = mayor;
        }
        public void AddBuilding(Building building)
        {
            AllBuildings.Add(building);
        }

        public void ListCity()
        {
            Console.WriteLine($"City: {_name}");
            Console.WriteLine($"Established: {_established}");
            Console.WriteLine($"Mayor: {_mayor}");
        }
    }
}