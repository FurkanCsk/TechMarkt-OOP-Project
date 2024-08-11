using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Project
{
    // Abstract base class for machines
    public abstract class BaseMachine
    {
        // Properties common to all machines
        public DateTime ProductionDate { get; set; }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        // Constructor that sets the production date to the current date
        public BaseMachine()
        {
            SetProductionDate();
        }

        // Sets the production date to thecurrent date and time
        public void SetProductionDate()
        {
            ProductionDate = DateTime.Now;
        }

        // Prints the common information for all machines
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Production Date: {ProductionDate}\nSerial Number: {SerialNumber}\nName: {Name}\nDescription: {Description}\nOperating System: {OperatingSystem}");
        }
        // Abstract method to be implemented by derived classes to display product name
        public abstract void DisplayProductName();
    }
}
