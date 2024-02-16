using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class MercedesBenz
    {
        public int TripKm { get; set; }

        public void Go()
        {
            Console.WriteLine("Car is going");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped");
        }

    }
}
