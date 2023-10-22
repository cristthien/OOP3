using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Car
{
    public class Car : IVehicle
    {
        private int _gasoline;
        public Car(int gasoline) { 
            this._gasoline = gasoline;
        }
        public void Drive()
        {
            if (_gasoline > 0) {
                Console.WriteLine("Driving");
            } else {
                Console.WriteLine("The car does not enough fuel");
            }
        }

        public void Refuel(int amoutOfGasline)
        {
            this._gasoline= this._gasoline+amoutOfGasline;
        }
    }
}
