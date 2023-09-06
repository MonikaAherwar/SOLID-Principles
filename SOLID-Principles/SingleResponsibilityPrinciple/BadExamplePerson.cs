using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.SingleResponsibilityPrinciple
{
    public class BadExamplePerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public BadExamplePerson(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        // Responsibility 1: Storing person data
        // Responsibility 2: Formatting data for display
        public string GetFormattedInfo()
        {
            return $"Name: {FirstName} {LastName}, Age: {CalculateAge()}";
        }

        private int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        /*
         * In this example, the Person class has two responsibilities: 
         * 1. storing person data
         * 2. formatting data for display. 
         * 
         * To adhere to the SRP, we can separate these responsibilities into two different classes:
         * 1. Person
         * 2. PersonHelper
         * */
    }
}
