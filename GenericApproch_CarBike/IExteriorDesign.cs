using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproch_CarBike
{
    internal interface IExteriorDesign<T>
    {
        string ExteriorDesign(T data);
    }
}
