using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_10.Interface;

namespace HW_10.Car_Park.DerivativesFreightCar
{
    public class FreightCar_2 : FreightCar
    {
        public FreightCar_2()
        {
            CarModel = "Mercedes-Benz";
            CarYear = 2021;
            GasolineConsumption = 11;
            CarPrys = 13000;
            LoadCapacity = 750;
        }
    }
}
