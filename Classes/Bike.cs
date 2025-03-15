using System;
using Task8.Interfaces;

namespace Task8.Classes

{
    public class Bike : IVehicle
    {
        public void StartEngine() => Console.WriteLine("Bike pedaling started");
        public void StopEngine() => Console.WriteLine("Bike brakes applied");
    }
}