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
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }

            // Comparison for "Heart rate is..." display
            if (heartRate > 40 && heartRate < 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }

            Console.ReadKey();
        }
    }
}
