using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproch_CarBike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" <======Output for Car======> \n");
            Car<string> car = new Car<string>("BMW", 2020, 500, 6, 5, 4, "Leathers", VehicleType.Car);
            Console.WriteLine(car.GetCarModel());
            Console.WriteLine($"Year Make : {car.YearMake}");
            Console.WriteLine($"Engine Capacity in CC : {car.EngineCapcityCC}");
            Console.WriteLine($"Number of Door : {car.NumberofDoor}");
            Console.WriteLine($"Number of Gear : {car.NumberofGear}");
            Console.WriteLine($"Number of Seat : {car.NumberofSeat}");
            Console.WriteLine($"Interior design : {car.interiorDesign}");
            car.StartEngine();
            car.RearBreak();
            car.FrontBreak();

            Console.WriteLine("\n <====== Output for MotorCycle ======> \n");
            MotorCycle<string> motor = new MotorCycle<string>("Royal Enfield Classic", 2019, 2, 120, "Electric start", 20, 27, 90, "Black", VehicleType.MotorCycle);
            Console.WriteLine(motor.GetMotorCycleModel());
            Console.WriteLine($"Year Make : {motor.YearMake}");
            Console.WriteLine($"Number of Gear : {motor.NumberofGear}");
            Console.WriteLine($"Engine Capacity in CC : {motor.EngineCapcityCC}");
            Console.WriteLine($"Maximum Power in BPH : {motor.MaxPowerBPH}");
            Console.WriteLine($"Maximum Torque in NM : {motor.MaxTorqueNM}");
            Console.WriteLine($"Mileage in KMPL : {motor.MileageKMPL}");
            Console.WriteLine($"Color :{motor.Color}");
            Console.WriteLine($"Starting method : {motor.StartingMethod}");
            motor.RearBreak();
            motor.FrontBreak();
            motor.StartEngine();
        }
    }
}
