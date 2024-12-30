using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproch_CarBike
{
    sealed class Car<T> : FourWheeler<T>
    {
        Car() { }
        public Car(string modelNo, int yearmake, int engineCapacityCC, int numberofGear, int numberofSeat, int numberofDoor, string interiordesign, VehicleType type) : this()
        {
            ModelNo = modelNo;
            YearMake = yearmake;
            EngineCapcityCC = engineCapacityCC;
            NumberofGear = numberofGear;
            NumberofDoor = numberofDoor;
            NumberofGear = numberofGear;
            interiorDesign = interiordesign;
            Type = type;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Engine started with keyless ignition");
        }
        public string GetCarModel()
        {
            return $"Car Model No : {ModelNo}";
        }
        public string GetCarModel(int year)
        {
            return $"Car Model No : {ModelNo} year : {year}";
        }
    }
}
