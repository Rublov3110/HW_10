using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10.Car_Park
{
    public abstract class CarPark : IComparable
    {
        public string? CarModel { get; init; }
        public int CarYear { get; init; }
        public int GasolineConsumption { get; init; }
        public int CarPrys { get; init; }
        public abstract void CarInf();

        public int CompareTo(object? obj)
        {
            int? resalt = 0;

            if (obj is CarPark)
            {
                CarPark? carPark = obj as CarPark;
                resalt = carPark?.GasolineConsumption.CompareTo(GasolineConsumption);
            }

            if (resalt == null)
            {
                return 0;
            }
            else
            {
                return (int)resalt;
            }
        }
    }
}
