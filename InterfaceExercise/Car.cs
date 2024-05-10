using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool hasTrunk {  get; set; }
        public bool hasAwd {  get; set; }
        public int numberOfWheels { get; set; }
        public int numberOfDoors { get; set; }
        public int engineSpeed { get; set; }
        public string location { get; set; }
        public string slogan { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string hasWeapons { get; set; }

        public void DisplayDetails()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hey V, got sweet car for you\ncheck your messages!");
            Console.WriteLine($"Make: {make} {slogan}\nModel: {model}\nYear: {year}\nDriveTrain:{numberOfWheels} wheels with full AWD {hasAwd} top speed of {engineSpeed}\nStorage: {numberOfDoors} doors and trunk {hasTrunk}\nDefense: {hasWeapons}\nWhere to pick up: {location} ");
            Console.ResetColor();
        }
    }
}
