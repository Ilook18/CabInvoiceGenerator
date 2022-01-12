using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        readonly public  double DISTANCE;
        readonly public  double TIME;
        public Ride(double RunningDistane, double RunningTime)
        {
            this.DISTANCE = RunningDistane;
            this.TIME = RunningTime;
        }
    }
}
