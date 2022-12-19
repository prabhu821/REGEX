﻿using REGEX.UserRegistrationProblem;

namespace REGEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("WELCOME TO USER REGISTRATION");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter option to choose \n1.First Name \n2.Last Name \n3.Exit");
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
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}