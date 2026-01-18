using System;

namespace Zadatak01
{
    public class URC : IRemoteControllable
    {
        public void SwitchOn() => Console.WriteLine("URC is on");

        public void SwitchOff() => Console.WriteLine("URC is off");

        public void VolumeUp() => Console.WriteLine("Volume up");

        public void VolumeDown() => Console.WriteLine("Volume down");
    }
}