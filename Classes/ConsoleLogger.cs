using System;
using Task8.Interfaces;

namespace Task8.Classes
{
    public class ConsoleLogger : ILogger
    {
        void ILogger.Log() => Console.WriteLine("Custom console log");
    }
}