﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> CarList { get; set; } = new List<Car>();

        public CarLot()
        {
        }

        public static int numberOfCars = 1;
    }
}
