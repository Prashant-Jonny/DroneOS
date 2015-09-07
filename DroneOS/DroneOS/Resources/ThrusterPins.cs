using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneOS.Resources
{
    public static class ThrusterPins
    {
        public static byte right = 1,
            left = 2,
            vrtFrontLeft = 0,
            vrtFrontRight = 0,
            vrtRearLeft = 0,
            vrtRearRight = 0,
            transFront = 0,
            transRear = 0,
            vrt = 3; //for beta vrt thruster only
    }
}
