

namespace DroneOS.Handlers
{
    class enums
    {
        public enum sendOpcodes {
            Hello = 1,
            Control = 2
      
        }

        public enum recvOpcodes {
            recvHello = 100
        }

        public enum motors {
            right = 1,
            left = 2,
            vrtFrontLeft = 0,
            vrtFrontRight = 0,
            vrtRearLeft = 0,
            vrtRearRight = 0,
            transFront = 0,
            transRear = 0,
            vrt = 3 //for beta vrt thruster only
        }
    }
}
