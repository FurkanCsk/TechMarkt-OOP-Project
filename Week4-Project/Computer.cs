using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Project
{
    // Derived class a representing a computer
    public class Computer : BaseMachine
    {
        public int _usbPortCount;
        public bool HasBluetooth { get; set; }

        // Property for USB port count with validation
        public int UsbPortCount 
        {
            get 
            {
                return _usbPortCount;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbPortCount = value;
                }
                else
                {
                    Console.WriteLine("Invalid USB port count! Please enter either 2 or 4. The USB port count has been set to -1.");
                    _usbPortCount = -1;
                }
            }
        }

        // Overrides PrintInfo to include additional information specific to computers
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"USB Port Count: {UsbPortCount}\nBluetooth Enabled: {HasBluetooth}");
        }

        // Overriders DisplayProductName to show the computer's name
        public override void DisplayProductName()
        {
            Console.WriteLine($"Computer Name: {Name}");
        }
    }
}
