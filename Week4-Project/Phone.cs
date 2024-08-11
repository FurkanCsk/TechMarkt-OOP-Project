using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Project
{
    // Derived class representing a phone
    public class Phone : BaseMachine
    {
        public bool IsLicensedForTurkey { get; set; }

        // Overrides PrintInfoto include additional information specific to phones
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Turkish License: {IsLicensedForTurkey}");
        }

        // Overrides DisplayProductName to show the phone's name
        public override void DisplayProductName()
        {
            Console.WriteLine($"Phone Name: {Name}");
        }
    }
}
