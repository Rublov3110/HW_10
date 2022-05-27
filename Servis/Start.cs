using HW_10.Interface;
using HW_10.Car_Park.DerivativesFreightCar;
using HW_10.Car_Park.DerivativesPassengerCar;
using HW_10.Car_Park;

namespace HW_10.Servis
{
    public class Start : IStart
    {
        public Start()
        {
            CarArray[0] = new FreightCar_1();
            CarArray[1] = new FreightCar_2();
            CarArray[2] = new FreightCar_3();
            CarArray[3] = new PassengerCar_1();
            CarArray[4] = new PassengerCar_2();
            CarArray[5] = new PassengerCar_3();
        }

        public CarPark[] CarArray { get; } = new CarPark[6];
        public void Run()
        {
            Array.Sort(CarArray);

            foreach (var car in CarArray)
            {
                car.CarInf();
            }

            int allPrys = 0;

            for (int i = 0; i < CarArray.Length; i++)
            {
                allPrys += CarArray[i].CarPrys;
            }

            Console.WriteLine($"Total cost of the car park:{allPrys} y.e");
        }

        public void Search(int userInfo)
        {
            for (int i = 0; i < CarArray.Length; i++)
            {
                if (userInfo == CarArray[i].CarPrys)
                {
                    CarArray[i].CarInf();
                }
            }
        }
    }
}
