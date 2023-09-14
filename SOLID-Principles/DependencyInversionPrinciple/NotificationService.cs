using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DependencyInversionPrinciple
{

    // This class is High Level Module
    // This does not depends on Lower Level Modules (EmailSender, SMSSender) directly which are concreate classes
    // This class is using INTERFACE - IMessageSender instead contcreate classses which ensured decoupling between both modules
    // Now this class is not directly depending on any specific concreate class or lower level module.

    // By following the DIP, you can easily swap out the concrete database implementation with another implementation (Ex: mock EmailSender, SMSSender)
    // without needing to modify the NotificationService class,
    // promoting flexibility and maintainability in our codebase.

    // This princliple also supports 'Dependency Injection Principle' via contrcutor injection.
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
