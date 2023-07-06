﻿namespace DemoLib
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to Console: {message}");
        }
    }
}