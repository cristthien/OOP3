using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Car
{
    public class TestCar
    {
        public void Main() {
            Car car = new Car(0);
            car.Drive();
            car.Refuel(10);
            car.Drive();
        }
    }
}
