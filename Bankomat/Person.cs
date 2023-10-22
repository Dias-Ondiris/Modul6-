using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Person
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Person(string FirstName, string LastName, DateTime DateOfBirth, string Gender, string Address, string Email, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;

        }
        public string GetFullInfo()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}, Gender: {Gender}, Address: {Address}, Email: {Email}, Phone: {PhoneNumber}";
        }

    }
    public static class PersonInfo
    {
        public static string GetPersonInfo(Person person)
        {
            return $"Name: {person.FirstName} {person.LastName}\nAge: {person.Age}\nGender: {person.Gender}\nAddress: {person.Address}\nEmail: {person.Email}\nPhone: {person.PhoneNumber}";
        }
    }

}
