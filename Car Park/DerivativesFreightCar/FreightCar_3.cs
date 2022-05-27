using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_10.Interface;

namespace HW_10.Car_Park.DerivativesFreightCar
{
    public class FreightCar_3 : FreightCar
    {
        public FreightCar_3()
        {
            CarModel = "ЗИЛ-131";
            CarYear = 2002;
            GasolineConsumption = 49;
            CarPrys = 10000;
            LoadCapacity = 5000;
        }
    }
}
