using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproch_CarBike
{
    internal class FourWheeler<T> : Vehicle<T>,IInteriorDesign<T>
    {
        public string InteriorDesign<T>(T data) where T : Vehicle<T>
        {
            return "Bmw car interior design ";
        }
        public string interiorDesign { get; set; }
        public int NumberofDoor {  get; set; }
        public override void RearBreak()
        {
            Console.WriteLine("Car rear break");
        }
        public override void FrontBreak()
        {
            Console.WriteLine("Car front break");
        }
    }
}
