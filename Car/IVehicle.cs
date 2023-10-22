using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Car
{
    public interface IVehicle
    {
        public void Drive();
        public void Refuel(int amoutOfGasline);
    }
}
