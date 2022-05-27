using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_10.Interface;

namespace HW_10.Car_Park
{
    public abstract class PassengerCar : CarPark, ICarInf
    {
        public string CarType => "Passenger car";
        public override void CarInf()
        {
            Console.WriteLine($"Сar type:{CarType}");
            Console.WriteLine($"Car model:{CarModel}");
            Console.WriteLine($"Year of issue:{CarYear}");
            Console.WriteLine($"Gasoline consumption:{GasolineConsumption} km/l");
            Console.WriteLine($"Car cost:{CarPrys} y.e");
            Console.WriteLine(new string('-', 70));
        }
    }
}
