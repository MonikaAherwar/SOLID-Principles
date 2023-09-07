using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DependencyInversionPrinciple
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

}
