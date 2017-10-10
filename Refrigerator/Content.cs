using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    class Content
    {
        private bool Door { get; set; }
        private string DoorOpen
        {
            get
            {
                if (Door)
                {
                    return "Open";
                }
                else
                {
                    return "Closed";
                }
            }
        }
            private string Light
        {
            get
            {
                if (Door)
                    return "Light is on";
                else
                    return "Light is off";
            }
        }
        public List<Items> FridgeContents;
        public Content()
        {
            FridgeContents = new List<Items>();
        }
        public void OpenDoor()
        {
            if (Door)
            {
                Door = false;
            }
            else
            {
                Door = true;
            }
        }
        public void AddItems(Items item)
        {
            FridgeContents.Add(item);
        }
        public override string ToString()
        {
            string retval = String.Format("Fridge is {0} and {1}. Contents: ", DoorOpen, Light);
            foreach(Items item in FridgeContents)
            {
                retval += "\n" + item.ToString();
            }
            return retval;
        }
    }
}
