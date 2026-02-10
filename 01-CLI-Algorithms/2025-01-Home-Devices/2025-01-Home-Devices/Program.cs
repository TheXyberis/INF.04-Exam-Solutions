using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_Home_Devices
{
    class Device
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    class WashingMachine : Device
    {
        private int _programNumber = 0;
        public int SetProgram(int number)
        {
            if (number >= 1 && number <= 12)
            {
                _programNumber = number;
            }
            else
            {
                _programNumber = 0;
            }
            return _programNumber;
        }
    }
    class VacuumCleaner : Device
    {
        private bool _isOn = false;
        public void On()
        {
            if (!_isOn)
            {
                _isOn = true;
                DisplayMessage("Vacuum cleaner turned on.");
            }
        }
        public void Off()
        {
            if (_isOn)
            {
                _isOn = false;
                DisplayMessage("Vacuum cleaner turned off.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WashingMachine washingMachine = new WashingMachine();
            VacuumCleaner vacuumCleaner = new VacuumCleaner();

            Console.WriteLine("Enter wash program number (1..12):");

            if(!int.TryParse(Console.ReadLine(), out int inputNumber))
            {
                inputNumber = 0;
            }

            if (washingMachine.SetProgram(inputNumber) != 0)
            {
                washingMachine.DisplayMessage("Program has been set successfully.");
            }
            else
            {
                washingMachine.DisplayMessage("Invalid program number entered.");
            }

            vacuumCleaner.On();
            vacuumCleaner.On();
            vacuumCleaner.On();
            vacuumCleaner.DisplayMessage("Vacuum cleaner battery is low.");
            vacuumCleaner.Off();

            Console.ReadKey();
        }
    }
}
