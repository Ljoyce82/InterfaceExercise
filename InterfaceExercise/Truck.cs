using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool hasBed {  get; set; }
        public bool hasFourWheelDrive { get; set; }
        public int numberOfWheels { get; set; }
        public int numberOfDoors { get; set; }
        public int engineSpeed { get; set; }
        public string location { get ; set ; }
        public string slogan { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string hasWeapons { get; set; }

        public void DisplayDetails()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hey V, got sweet Truck for you\ncheck your messages!");
            Console.WriteLine($"Make: {make} {slogan}\nModel: {model}\nYear: {year}\nDriveTrain: {numberOfWheels} wheels with AWD {hasFourWheelDrive} top speed {engineSpeed}\nStorage: Doors {numberOfDoors} and empty bed {hasBed}\nDefense: {hasWeapons}\nWhere to pick up: {location} ");
            Console.ResetColor();
        }   

    }
}
