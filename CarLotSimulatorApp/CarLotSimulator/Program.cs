using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot carLot = new CarLot();

            var firstCar = new Car();
            firstCar.Year = 1992;
            firstCar.Make = "Renault";
            firstCar.Model = "Koleos";
            firstCar.EngineNoise = "br br br";
            firstCar.HonkNoise = "honk honk";
            firstCar.IsDriveable = true;

            carLot.CarList.Add(firstCar);

            firstCar.MakeEngineNoise();
            firstCar.MakeHonkNoise();

            var secondCar = new Car(2006, "Yamaha", "TTR125E", "whing whing", "bam bam", true);

            secondCar.MakeEngineNoise();
            secondCar.MakeHonkNoise();

            carLot.CarList.Add(secondCar);

            var thirdCar = new Car()
            {
                Year = 2008,
                Make = "FrieghtLiner",
                Model = "Coronado",
                EngineNoise = "brr brrt krkrkr kek",
                HonkNoise = "wheeeee",
                IsDriveable = false
            };

            thirdCar.MakeEngineNoise();
            thirdCar.MakeHonkNoise();

            carLot.CarList.Add(thirdCar);

            foreach (var car in carLot.CarList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

             
        }
    }
}
