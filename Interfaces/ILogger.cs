using System;

namespace Task8.Interfaces
{
    public interface ILogger
    {
        void Log() => Console.WriteLine("Default log");
    }
}
