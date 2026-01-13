using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Delegates
{
    /*
     Delegate for Validation
Create a delegate that validates:
Email
Password
Phone number
     */
    public delegate bool Validator(string s);
    internal class DelegateValidation
    {
        public static void Execute()
        {
            Validator emailValidator = ValidateEmail;
            Console.WriteLine("Validation check for email: "+emailValidator("abc@gmail.com"));

            Validator passwordValidator = ValidatePassword;
            Console.WriteLine("Validation check for password: " + passwordValidator("p87654321"));

            Validator phoneValidator = ValidatePhone;
            Console.WriteLine("Validation check for phone: " + passwordValidator("9999955555"));

        }
        public static bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public static bool ValidatePassword(string password)
        {
            return password.Length >= 8;
        }
        public static bool ValidatePhone(string  phone)
        {
            return phone.StartsWith("9") && phone.Length == 10;
        }
    }
}
