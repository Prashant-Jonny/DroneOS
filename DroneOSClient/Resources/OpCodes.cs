namespace DroneOSServer.Resources
{
    public enum SendOpcodes : byte
    {
        Hello = 1,
        Thruster = 2,
        Sensor = 3,
        Servo = 4,
        Mission = 5,
        Shutdpwm = 9
    }

    public enum RecvOpcodes : byte
    {
        //Misc. Headers
        recvHello = 100,

        //Data Headers

        //Camera Headers
        Cam1Raw = 201,
        Cam1Proc = 202,
        Cam2Raw = 203,
        Cam2Proc = 204,
    }
}
