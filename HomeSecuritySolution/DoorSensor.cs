using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSecuritySolution
{
    public delegate void DoorPositionHandler(string position);
    public class DoorSensor
    {
        string position;
        public event DoorPositionHandler OnDoorPositionChanged;
        public void Open()
        {
            position = "open";
            OnDoorPositionChanged.Invoke(this.position);

        }

        public void Close()
        {
            position = "close";
            OnDoorPositionChanged.Invoke(this.position);
        }



    }
}


