using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            SecuritySystem _observer_security = new SecuritySystem();
            DoorPositionHandler _addressOfNotify = new DoorPositionHandler(_observer_security.Notify);

            DoorSensor door = new DoorSensor();
            door.OnDoorPositionChanged += _addressOfNotify;
            door.Open();
            door.Close();

        }
    }
}