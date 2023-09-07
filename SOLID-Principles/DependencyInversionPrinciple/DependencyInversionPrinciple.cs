using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DependencyInversionPrinciple
{
    internal class DependencyInversionPrinciple
    {
        public DependencyInversionPrinciple()
        {
            Console.WriteLine("**************** DEFINITION ********************");
            Console.WriteLine("The Dependency Inversion Principle (DIP) states that " +
                "high-level modules should not depend on low-level modules. Both should depend on abstractions. " +
                "Additionally, abstractions should not depend on details; details should depend on abstractions. " +
                "In other words, rather than depending on concrete implementations, " +
                "code should depend on abstractions, making it more flexible and easier to maintain.");
            Console.WriteLine("");
        }

        public void Problem()
        {
            Console.WriteLine("**************** PROBLEM ***********************");
            Console.WriteLine("Classes depends on concrete details instead of abstraction");
            Console.WriteLine("");
        }

        public void Solution()
        {
            Console.WriteLine("**************** SOLUTION **********************");
            Console.WriteLine("Add abstraction level. This ensures decoupling and better separation of concerns");
            Console.WriteLine("");
        }

        /*
         * The NotificationService class, a high-level module, depends on IMessageSender rather than specific implementations.
         * This adheres to the Dependency Inversion Principle.
         * At runtime, we can inject different implementations of IMessageSender (e.g., EmailSender or SMSSender) into the NotificationService, 
         * allowing us to switch message sending mechanisms without modifying the NotificationService class.
         */
    }
}
