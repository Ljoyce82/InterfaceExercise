using System;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var archer = new Car();
            archer.make = "Thorton";
            archer.model = "Colby";
            archer.year = 2077;
            archer.hasWeapons = "None";
            archer.engineSpeed = 90;
            archer.location = "NightCity Mox Club";
            archer.slogan = "Style over Substance";
            archer.numberOfWheels = 4;
            archer.numberOfDoors = 2;
            archer.hasAwd = true;
            archer.hasTrunk = true;

            var kuma = new Suv();
            kuma.make = "Mahir Supron";
            kuma.model = "Trailbruiser";
            kuma.year = 2077;
            kuma.hasWeapons = "Missiles and front machine guns";
            kuma.engineSpeed = 95;
            kuma.location = "Nightcity Delimann Garage";
            kuma.slogan = "Armored and ready for Dogtown";
            kuma.numberOfWheels = 4;
            kuma.numberOfDoors = 4;
            kuma.hasFrontGuardBumper = true;
            kuma.hasThridRowSeats = false;

            var saguaro = new Truck ()
            {  
            make = "Thorton Mackinaw",
            model = "Saguaro",
            year = 2077,
            hasWeapons = "Side Guns",
            engineSpeed = 125,
            location = "NightCity Dakota",
            slogan = "When you value function over form",
            numberOfWheels = 4,
            numberOfDoors = 2,
            hasBed = true,
            hasFourWheelDrive = true,
            };

            archer.DisplayDetails();
            Console.WriteLine();
            kuma.DisplayDetails();
            Console.WriteLine();
            saguaro.DisplayDetails();

        }

            

            
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

        //Create 3 classes called Car , Truck , & SUV

        //In your IVehicle:

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: public int NumberOfWheels { get; set; }
         */


        //In ICompany: 

        /* Create 2 members that are specific to each every company
         * regardless of vehicle type.
         * Example: public string Logo { get; set; }
         */

        //In each of your Car, Truck, and SUV classes

        /* Create 2 members that are specific to each class
         * Example for Car: public bool HasTrunk { get; set; }
         * Example for SUV: public int NumberOfSeats { get; set; }
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         */

        //Now, create objects of your 3 classes and give their members values.
        //Creatively display and organize their values

        //Option for displaying values: 
        //Create a stubbed out method called DisplayDetails in your IVehicle interface.
        //Implement the stubbed out method in the derived classes.
        //In the scope of them method, use string interpolation to display property values.
        //In order to also interpolate values from ICompany, research how to extend interfaces.
             
            
        
    }
}
