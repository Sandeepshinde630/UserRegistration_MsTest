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
            try
            {
                if (result != true)
                {
                    throw new Exception("Input string is not in correct format");
                }

                Console.WriteLine(result);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}

