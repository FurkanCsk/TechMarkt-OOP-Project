using System;
using System.Numerics;
using Week4_Project;

bool continueProgram = true;

while(continueProgram)
{
    Console.WriteLine("Welcome to TechMarkt!");

    // Get user's choice for creating a Computer or Phone
    int choice = GetUserChoice();

    switch(choice)
    {
        case 1:
            ComputerCreation();
            break;

        case 2:
            PhoneCreation();
            break;
    }

    // Ask user if they want to continue
    continueProgram = AskToContinue();
}


// Prompts the user to select either 1 or 2 and validates the input
int GetUserChoice()
{

    bool IsValidChoice = false;
    int choice = 1;

    while (!IsValidChoice)
    {
        Console.WriteLine("1 - Create Computer\n2 - Create Phone\n Please select 1 or 2:");

        if (int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2))
        {
            IsValidChoice = true;
        }
        else
            Console.WriteLine("Invalid input. Please enter either 1 or 2.");
    }
    return choice;
}

// Creates a new computer object and gathers its details from the user
void ComputerCreation()
{
    Computer computer = new Computer();
    MachineDetails(computer);

    computer.UsbPortCount = GetIntInput("Enter the USB port count: ");
    computer.HasBluetooth = GetYesNoInput("Does thecomputer support Bluetooth? (Yes/No)");

    Console.WriteLine("Computer specifications:");
    computer.PrintInfo();

}

// Creates a new phone object and gathers its details from the user
void PhoneCreation()
{
    Phone phone = new Phone();
    MachineDetails(phone);

    phone.IsLicensedForTurkey = GetYesNoInput("Is the phone licensed for use in Turkey? (Yes/No):");

    Console.WriteLine("Phone specifications");
    phone.PrintInfo();

}

// Gathers common machine details from the user
void MachineDetails(BaseMachine machine)
{
    machine.SerialNumber = GetIntInput("Enter the serial number:");
    machine.Name = GetStringInput("Enter the name:");
    machine.Description = GetStringInput("Enter a description:");
    machine.OperatingSystem = GetStringInput("Enter the operating system:");
}

// Prompts the user for an integer input with validation
 int GetIntInput(string text)
{
    int value = 0;
    bool validInput = false;

    while (!validInput)
    {
        Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(), out value))
        {
            validInput = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }
    return value;
}

// Prompts the user for a yes/no input and returns as a boolean
bool GetYesNoInput(string text)
{
    bool validInput = false;
    bool result = false;

    while (!validInput)
    {
        Console.WriteLine(text);
        string input = Console.ReadLine().ToLower();

        if (input == "yes" || input == "y")
        {
            result = true;
            validInput = true;
        }
        else if (input == "no" || input == "n")
        {
            result = true;
            validInput = true;
        }
        else
        {
            Console.WriteLine("Invalid input.Please enter 'Yes'or 'No'");
        }

    }
    return result;
}

// Prompts the user for a string input
string GetStringInput(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine();
}

//Asks the user if they want to continue and returns a boolean indicating their choice
bool AskToContinue()
{
    Console.WriteLine("Do you want to continue? (Yes/No)");
    string continueInput = Console.ReadLine().ToLower();
    bool continueProgram = !(continueInput == "no" || continueInput == "n");

    if (!continueProgram)
    {
        Console.WriteLine("Thank you for using TechMarkt. Goodbye!");
    }
    return continueProgram;
}