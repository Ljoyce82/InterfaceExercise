using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public bool hasThridRowSeats {  get; set; }
        public bool hasFrontGuardBumper { get; set; }
        public int numberOfWheels { get; set; }
        public int numberOfDoors { get; set; }
        public int engineSpeed { get; set; }
        public string location { get ; set ; }
        public string slogan { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string hasweapons { get; set; }

        public void DisplayDetails()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Hey V, got sweet SUV for you\ncheck your messages!");
            Console.WriteLine($"Make: {make} {slogan}\nModel: {model}\nYear: {year}\nDriveTrain:{numberOfWheels} wheels with a top speed {engineSpeed}\nStorage: {numberOfDoors} doors with extra seats {hasThridRowSeats}\nDefense: {hasweapons} and a reinforced bumper {hasFrontGuardBumper}\nWhere to pick up: {location} ");
            Console.ResetColor();
        }

    }
}
