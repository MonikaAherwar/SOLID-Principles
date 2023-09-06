using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.SingleResponsibilityPrinciple
{
    public class PersonHelper
    {
        public string GetFormattedInfo(Person person)
        {
            return $"Name: {person.FirstName} {person.LastName}, Age: {CalculateAge(person)}";
        }

        private int CalculateAge(Person person)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - person.BirthDate.Year;
            if (person.BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }


    }
}
