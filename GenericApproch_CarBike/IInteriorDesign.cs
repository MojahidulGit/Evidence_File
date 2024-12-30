using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproch_CarBike
{
    internal interface IInteriorDesign<T>
    {
        string InteriorDesign<T>(T data) where T : Vehicle<T>;
    }
}
