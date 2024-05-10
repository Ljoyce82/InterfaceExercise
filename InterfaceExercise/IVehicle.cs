using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int numberOfWheels { get; set; }
        public int numberOfDoors { get; set; }
        public string hasweapons { get; set;}
        public int engineSpeed { get; set;}
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }

        public void DisplayDetails();
    }
}
