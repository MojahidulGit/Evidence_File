using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproch_CarBike
{
    sealed class MotorCycle<T> : TwoWheeler<T>
    {
        MotorCycle() { }
        public MotorCycle(string modelNo, int yearMake, int numberofGear, int engineCapacityCC, string startingMethod, int maxPowerBPH, int maxTorqueNM, int mileageKMPL, string color, VehicleType type) : this()
        {
            ModelNo = modelNo;
            YearMake = yearMake;
            NumberofGear = numberofGear;
            EngineCapcityCC = engineCapacityCC;
            StartingMethod = startingMethod;
            MaxPowerBPH = maxPowerBPH;
            MaxTorqueNM = maxTorqueNM;
            MileageKMPL = mileageKMPL;
            Color = color;
            Type = type;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Engine started with kick");
        }
        public string GetMotorCycleModel()
        {
            return $"MotorCycle Model No :{ModelNo}";
        }
    }
}
