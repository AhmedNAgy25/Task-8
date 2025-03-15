using System;
using Task8.Interfaces;

namespace Task8.Classes

{
    public class Car : IVehicle
    {
        public void StartEngine() => Console.WriteLine("Car engine started");
        public void StopEngine() => Console.WriteLine("Car engine stopped");
    }
}