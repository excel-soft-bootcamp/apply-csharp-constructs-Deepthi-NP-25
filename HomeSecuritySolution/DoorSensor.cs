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
        string DoorPosition;
        public event DoorPositionHandler OnDoorPositionChanged;

        public void Open()
        {
            DoorPosition = "Door is Opened";
            OnDoorPositionChanged.Invoke(this.DoorPosition);
        }
        public void Close()
        {
            DoorPosition = "Door is Closed";
            OnDoorPositionChanged.Invoke(this.DoorPosition);
        }
        public void Add_Observer(DoorPositionHandler observer)
        {
            OnDoorPositionChanged += observer;
        }
        public void Remove_Observer(DoorPositionHandler observer)
        {

            OnDoorPositionChanged -= observer;
        }

    }
}

