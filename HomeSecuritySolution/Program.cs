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
            SecuritySystem _securitySystem = new SecuritySystem();
            DoorPositionHandler doorPositionChangeHandler = new DoorPositionHandler(_securitySystem.Notify);


            DoorSensor doorSensor = new DoorSensor();
            doorSensor.OnDoorPositionChanged += doorPositionChangeHandler;
            doorSensor.Open();
            doorSensor.Close();


        }
    }
}