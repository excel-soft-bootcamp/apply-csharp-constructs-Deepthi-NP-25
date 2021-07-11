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
            this.Send();

        }

        public void Close()
        {
            position = "close";
            this.Send();
        }
        public void Send()
        {
            string message = $"{this.position} and Time : {System.DateTime.Now.ToString()}";
            OnDoorPositionChanged.Invoke(message);
        }



    }
}


