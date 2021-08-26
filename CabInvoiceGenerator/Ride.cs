using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Ride class to set data for particular ride
    /// </summary>
    public class Ride
    {
        // variables
        public double distance;
        public int time;
        /// <summary>
        /// parameterized constructor for setting the data
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
