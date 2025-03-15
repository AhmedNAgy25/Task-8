using System;
using Task8.Interfaces;

namespace Task8.Classes

{
    public class Robot : IWalkable
    {
        void IWalkable.Walk() => Console.WriteLine("Robot walking mechanically");
    }
}