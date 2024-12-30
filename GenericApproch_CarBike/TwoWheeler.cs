using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproch_CarBike
{
    internal class TwoWheeler<T> : Vehicle<T>, IExteriorDesign<T>
    {
        public string ExteriorDesign(T data)
        {
            return " Sporty MotorCycle exterior desigin";
        }
        public string StartingMethod { get; set; }
        public int MaxPowerBPH { get; set; }
        public int MaxTorqueNM { get; set; }
        public int MileageKMPL { get; set; }
        public string Color { get; set; }
        public override void FrontBreak()
        {
            Console.WriteLine("MotorCycle Front break");
        }
        public override void RearBreak()
        {
            Console.WriteLine("MotorCycle rear break");
        }
    }
}
