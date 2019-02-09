using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Section for declaring constants
            const byte sample1 = 0x3A;
            const float acceleration = 9.800F;
            const char integral = '\u222B';
            const string greeting = "Hello";

            // Section for declaring variables
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            string name = "Karen";

            // Main tasks start here with "sample" comparison
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.\n");
            }
            else
            {
                Console.WriteLine("The samples are not equal.\n");
            }

            // Comparison for "Heart rate is..." display
            if (heartRate > 40 && heartRate < 80)
            {
                Console.WriteLine("Heart rate is normal.\n");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.\n");
            }

            // Comparison for "deposits" display
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.\n");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.\n");
            }

            // Declaring force = mass x accel as a float
            float force = mass * acceleration;
            Console.WriteLine("force = {0}\n" , force);

            // Displaying "distance"
            Console.WriteLine("{0} is the distance.\n", distance);

            // Comparing "lost" and "expensive"
            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.\n");
            }
            if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is a coupon for 10% off.\n");
            }

            // Switch/case for "choice" int
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.\n");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.\n");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.\n");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.\n");
                    break;
            }

            // Displaying "integral"
            Console.WriteLine("{0} is an integral.\n", integral);

            // Counting from 5 to 10 with a "for" loop
            for (int i = 5; i <= 10 ; i++)
            {
                if (i < 10)
                {
                    Console.WriteLine("i = {0}", i);
                }
                else
                {
                    Console.WriteLine("i = {0}\n", i);
                }
            }

            // "While" loop with "age"
            int age = 0;
            while (age < 6)
            {
                if (age < 5)
                {
                    Console.WriteLine("age = {0}", age);
                    age++;
                }
                else
                {
                    Console.WriteLine("age = {0}\n", age);
                    age++;
                }
            }

            // Displaying "greeting" and "name" Strings
            Console.WriteLine("{0} {1}\n", greeting, name);

            Console.ReadKey();
        }
    }
}
