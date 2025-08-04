using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Checking vitals...");
            bool result = Checker.VitalsOk(98.6f, 75, 95);
            if (result)
            {
                Console.WriteLine("All vitals are within normal range.");
            }
            else
            {
                Console.WriteLine("Some vitals are out of range.");
            }
        }
    }
}
