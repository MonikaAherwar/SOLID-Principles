using System;
using Microsoft.VisualBasic;
using SOLID_Principles.DependencyInversionPrinciple;
using SOLID_Principles.LiskovSubstitutionPrinciple;
using SOLID_Principles.OpenClosePrinciple;
using SOLID_Principles.SingleResponsibilityPrinciple;

namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the parent project which demonstrate 'SOLID PRINCIPLES' in C# .NET");
            Console.WriteLine("");

            // Single Responsibility Principle
            SingleResponsibilityPrinciple.SingleResponsibilityPrinciple srp = new SingleResponsibilityPrinciple.SingleResponsibilityPrinciple();
            srp.Problem();
            srp.Solution();

            // Open Close Principle
            var drawing = new Drawing();
            drawing.AddShape(new Rectangle(5, 4));
            drawing.AddShape(new Circle(3));

            double totalArea = drawing.CalculateTotalArea();
            Console.WriteLine($"Total Area: {totalArea}");

            // Liskov's Substitution Principle
            Bird sparrow = new Bird();
            Bird ostrich = new Ostrich();

            BirdFly.MakeBirdFly(sparrow); // Outputs: "A bird can fly."
            BirdFly.MakeBirdFly(ostrich); // Outputs: "An ostrich cannot fly."

            // The Liskov Substitution Principle allows us to use an Ostrich
            // (derived class) in place of a Bird (base class) without issues.

            Ostrich newOstrich = new Ostrich();
            newOstrich.Run(); // Outputs: "An ostrich can run fast."

            // We can still access the unique method of the Ostrich class.

            // Interface Segregation Priciple
            // Example here

            // Dependency Inversion Principle
            IMessageSender emailSender = new EmailSender();
            IMessageSender smsSender = new SMSSender();

            NotificationService emailNotification = new NotificationService(emailSender);
            NotificationService smsNotification = new NotificationService(smsSender);

            emailNotification.SendNotification("Hello, this is an email notification.");
            smsNotification.SendNotification("Hello, this is an SMS notification.");
        }

        private static void SingleResponsibilityPrinciple()
        {
            SingleResponsibilityPrinciple.SingleResponsibilityPrinciple srp = new SingleResponsibilityPrinciple.SingleResponsibilityPrinciple();
            srp.Problem();
            srp.Solution();
        }

        private static void OpenClosePrincipl()
        {
            var drawing = new Drawing();
            drawing.AddShape(new Rectangle(5, 4));
            drawing.AddShape(new Circle(3));

            double totalArea = drawing.CalculateTotalArea();
            Console.WriteLine($"Total Area: {totalArea}");
        }

        private static void LiskovSubstitutionPrinciple()
        {
            Bird sparrow = new Bird();
            Bird ostrich = new Ostrich();

            BirdFly.MakeBirdFly(sparrow); // Outputs: "A bird can fly."
            BirdFly.MakeBirdFly(ostrich); // Outputs: "An ostrich cannot fly."

            // The Liskov Substitution Principle allows us to use an Ostrich
            // (derived class) in place of a Bird (base class) without issues.

            Ostrich newOstrich = new Ostrich();
            newOstrich.Run(); // Outputs: "An ostrich can run fast."

            // We can still access the unique method of the Ostrich class.
        }

        private static void InterfaceSegregationPriciple()
        {
        }

        private static void DependencyInversionPrinciple()
        {
            IMessageSender emailSender = new EmailSender();
            IMessageSender smsSender = new SMSSender();

            NotificationService emailNotification = new NotificationService(emailSender);
            NotificationService smsNotification = new NotificationService(smsSender);

            emailNotification.SendNotification("Hello, this is an email notification.");
            smsNotification.SendNotification("Hello, this is an SMS notification.");
        }

    }
}
