﻿using System;

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
            bool result3 = pattern.ValidateLastName("91 7757929383");
            bool result4 = pattern.ValidateLastName("SandeepShinde");
            bool result5 = pattern.ValidatePasswordRule2("Xyz@12345");

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
                if (result3 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }

                Console.WriteLine(result3);
                if (result4 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }

                Console.WriteLine(result4);
                if (result5 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }

                Console.WriteLine(result5);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}

