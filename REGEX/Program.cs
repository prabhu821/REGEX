using REGEX.Email;
using REGEX.UserRegistrationProblem;

namespace REGEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            ValidEmail validEmail = new ValidEmail();
            Console.WriteLine("WELCOME TO USER REGISTRATION");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter option to choose \n1.First Name \n2.Last Name \n3.Email \n4.Mobile Number" +
                    " \n5.Password \n6.Check valid Email \n7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nEnter First Name");
                        string fName = Console.ReadLine();
                        userRegistration.validateFirstName(fName);
                        break;
                    case 2:
                        Console.WriteLine("\nEnter Last Name");
                        string lName = Console.ReadLine();
                        userRegistration.validateLastName(lName);
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Email");
                        string email = Console.ReadLine();
                        userRegistration.validateEmail(email);
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Mobile Number");
                        string mobileNumber = Console.ReadLine();
                        userRegistration.validateMobileNumber(mobileNumber);
                        break;
                    case 5:
                        Console.WriteLine("\nEnter Password");
                        string password = Console.ReadLine();
                        userRegistration.validatePassword(password);
                        break;
                    case 6:
                        Console.WriteLine("\nEnter to check a valid email or not");
                        string str=Console.ReadLine();
                        validEmail.CheckEmail(str);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}