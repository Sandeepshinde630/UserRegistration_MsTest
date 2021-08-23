using System;

namespace UserRegistration_MSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration MSTest");
            Pattern pattern = new Pattern();
            bool result = pattern.ValidateFirstName("Sandeep");
            bool result1 = pattern.ValidateLastName("Shinde");
            bool result2 = pattern.ValidateEmail("Sandeepshinde630@gmail.com");

            try
            {
                if (result != true)
                {
                    throw new Exception("Input string is not in correct format");
                }

                Console.WriteLine(result);
                if (result1 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }
                Console.WriteLine(result1);

                if (result2 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }

                Console.WriteLine(result2);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}

