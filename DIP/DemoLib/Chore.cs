﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class Chore : IChore
    {
        ILogger _logger;
        IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsCompleted { get; set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");

        }
        public void CompleteChore()
        {
            IsCompleted = true;
            _messageSender.SendMessage(Owner, $"The Chore {ChoreName} is completed.");

        }
    }
}
