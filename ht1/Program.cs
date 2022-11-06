using System;
using System.Text.RegularExpressions;

namespace ht1
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] Users = new object[0];
            Console.WriteLine("Register !");
            Console.Write("username: ");
            string usernameStr = Console.ReadLine();
            Console.Write("Name: ");
            string nameStr = Console.ReadLine();
            Console.Write("Surname: ");
            string surnameStr = Console.ReadLine();
            Console.Write("Age: ");
            string ageStr = Console.ReadLine();
            Console.Write("Email: ");
            string emailStr = Console.ReadLine();
            Console.Write("password: ");
            string passwordStr = Console.ReadLine();
            Console.Write("PhoneNumber: ");
            string phoneNumberStr = Console.ReadLine();

            Regex usernameRegex = new Regex(@"^[a-z]\S");
            Regex nameRegex = new Regex(@"^[A-Z]{1}[a-z]{1,14}$");
            Regex ageRegex = new Regex(@"\d");
            Regex emailRegex = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
            Regex passwordRegex = new Regex(@"\w");
            Regex phoneRegex = new Regex(@"^\+994\-[0-9]{2}\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}");

            Match usernameValidation = usernameRegex.Match(usernameStr);
            Match nameValidation = nameRegex.Match(nameStr);
            Match surnameValidation = nameRegex.Match(surnameStr);
            Match ageValidation = ageRegex.Match(ageStr);
            Match emailValidation = emailRegex.Match(emailStr);
            Match passwordValidation = passwordRegex.Match(passwordStr);
            Match phoneValidation = phoneRegex.Match(phoneNumberStr);

            if(usernameValidation.Success && nameValidation.Success && surnameValidation.Success && ageValidation.Success && emailValidation.Success && passwordValidation.Success && phoneValidation.Success)
            {
                var User = new { username = usernameStr, name = nameStr, surname = surnameStr, age = ageStr, email = emailStr, password = passwordStr, phoneNumber = phoneNumberStr };
                Array.Resize(ref Users, Users.Length + 1);
                Users[Users.Length - 1] = User;
                Console.WriteLine("User created !");

            }
            else
            {
                Console.WriteLine("invalid validation !");
            }




        }
    }
}


