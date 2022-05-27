using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_10.Interface;

namespace HW_10.Car_Park.DerivativesFreightCar
{
    public class FreightCar_1 : FreightCar
    {
        public FreightCar_1()
        {
            CarModel = "Volkswagen";
            CarYear = 2019;
            GasolineConsumption = 11;
            CarPrys = 10000;
            LoadCapacity = 1500;
        }
    }
}
