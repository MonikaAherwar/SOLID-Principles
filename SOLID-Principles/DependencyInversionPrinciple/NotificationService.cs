using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DependencyInversionPrinciple
{
    public class NotificationService
    {
        private readonly IMessageSender sender;

        public NotificationService(IMessageSender sender)
        {
            this.sender = sender;
        }

        public void SendNotification(string message)
        {
            sender.SendMessage(message);
        }
    }

}
