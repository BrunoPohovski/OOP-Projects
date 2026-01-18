using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadatak01
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            ISwitchable lightBulb = new LightBulb
            {
                Power = 5,
                FilamentLength = 100
            };

            ISwitchable stove = new Stove
            {
                Producer = "Gorenje",
                Type = Stove.StoveType.Gas
            };
            
            IList<ISwitchable> devices = new List<ISwitchable> 
            {
                lightBulb, 
                stove,
                new URC()
            };
            
            /*devices.ToList().ForEach(device =>
            {
                device.SwitchOn();

                if (device is IRemoteControllable remote)
                {
                    remote.VolumeUp();
                    remote.VolumeDown();
                }
                
                device.SwitchOff();
            });*/

            foreach (var device in devices)
            {
                device.SwitchOn();

                if (device is IRemoteControllable remote)
                {
                    remote.VolumeUp();
                    remote.VolumeDown();
                }
                
                device.SwitchOff();
            }
            
            
        }
    }
}