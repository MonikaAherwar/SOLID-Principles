using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DependencyInversionPrinciple
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

}
