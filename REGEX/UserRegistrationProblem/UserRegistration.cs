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
    }
}
