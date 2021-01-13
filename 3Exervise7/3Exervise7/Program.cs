/*
Programmer: Felipe SG
Date: 12/01/2021
Program: 3Exercise7
Objective: 
The gravitational field of the Moon is approximately 17% of that on the
Earth. Write a program that calculates the weight of a man on the
moon by a given weight on the Earth.
 */


using System;

namespace _3Exervise7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double weight, moonWeight;

            Console.WriteLine("Welcome \n");
            Console.WriteLine("Please inform how much you weight : ");
            weight = Convert.ToUInt32(Console.ReadLine());


            // Calculate the weight
            moonWeight = weight * 0.17;
            // Print the result
            Console.WriteLine("Your weight on the moon would be: {0}", moonWeight);
        }
    }
}
