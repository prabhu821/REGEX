using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX.UserRegistrationProblem
{
    internal class UserRegistration
    {
        public static string FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Email = "^[a-zA-Z0-9]+@[a-zA-Z]+.+([co.in|com])$";
        public static string MobileNumber = "^[1-9]{2}[: :][0-9]{10}$";
        public static string Password = "^.*(?=.{8,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$";

        //FIRST NAME
        public void validateFirstName(string fName)
        {
            if (Regex.IsMatch(fName, FirstName))
            {
                Console.WriteLine("First Name : " + fName);
            }
            else
            {
                Console.WriteLine("First alphabet should be capital and minimum 3 character");
            }
        }

        //LAST NAME
        public void validateLastName(string lName)
        {
            if (Regex.IsMatch(lName, LastName))
            {
                Console.WriteLine("Last Name : " + lName);
            }
            else
            {
                Console.WriteLine("First alphabet should be capital and minimum 3 character");
            }
        }

        //EMAIL
        public void validateEmail(string email)
        {
            if (Regex.IsMatch(email, Email))
            {
                Console.WriteLine("Email Address : " + email);
            }
            else
            {
                Console.WriteLine("Please enter a valid email address 'ex :- abc@xyz.co.in/.com'");
            }
        }

        //MOBILE NUMBER
        public void validateMobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, MobileNumber))
            {
                Console.WriteLine("Mobile Number : " + mobileNumber);
            }
            else
            {
                Console.WriteLine("Please enter a valid 10 digit mobile number with 2 digit country code ex 'xx 9xxxxxxx45'");
            }
        }

        //PASSWORD RULE 1,RULE 2,RULE 3,RULE 4
        public void validatePassword(string password)
        {
            if (Regex.IsMatch(password, Password))
            {
                Console.WriteLine("Password : " + password);
            }
            else
            {
                Console.WriteLine("For password minimum 8 characters required and atleast 1 upper case and atleast 1 numeric number and 1 special character");
            }
        }
    }
}
