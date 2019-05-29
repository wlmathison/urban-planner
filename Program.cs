using System;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue");
            FiveOneTwoEight.Width = 350.75;
            FiveOneTwoEight.Depth = 525.15;
            FiveOneTwoEight.Stories = 12;

            FiveOneTwoEight.Construct();
            FiveOneTwoEight.Purchase("Jameka Echols");

            Building OneTwoThreeFour = new Building("123 4th Avenue");
            OneTwoThreeFour.Width = 230.65;
            OneTwoThreeFour.Depth = 380.00;
            OneTwoThreeFour.Stories = 6;

            OneTwoThreeFour.Construct();
            OneTwoThreeFour.Purchase("Alex Thacker");

            Building TwoFourSixEigth = new Building("246 8th Avenue");
            TwoFourSixEigth.Width = 464.95;
            TwoFourSixEigth.Depth = 634.50;
            TwoFourSixEigth.Stories = 10;

            TwoFourSixEigth.Construct();
            TwoFourSixEigth.Purchase("Jon Schaffer");

            // FiveOneTwoEight.List();
            // OneTwoThreeFour.List();
            // TwoFourSixEigth.List();

            City Nashville = new City("Nashville");
            Nashville.Founded(1779, 1, 1);
            Nashville.ElectMayor("David Briley");

            Nashville.AddBuilding(FiveOneTwoEight);
            Nashville.AddBuilding(OneTwoThreeFour);
            Nashville.AddBuilding(TwoFourSixEigth);

            Nashville.ListCity();
            Console.WriteLine();
            Console.WriteLine("Buildings:");
            foreach (Building building in Nashville.AllBuildings)
            {
                building.List();
            }

        }
    }
}
