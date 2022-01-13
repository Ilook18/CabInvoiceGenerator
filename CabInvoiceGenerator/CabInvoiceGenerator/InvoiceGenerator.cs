﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InviceGenerator
    {
        readonly private double MIN_FARE = 5.0;
        readonly private double COST_PER_KM = 10.0;
        readonly private double COST_PER_MINUTE = 1.0;

        public double CalculateFare(double DISTANCE,double TIME)
        {
            double TotalFare = (DISTANCE * COST_PER_KM) + (TIME * COST_PER_MINUTE);
            if (TotalFare < MIN_FARE)
            {
                return MIN_FARE;
            }
            else
            {
                return TotalFare;
            }
        }
        public double CalculateMultipleRideFare(Ride[] ride)
        {
            double TotalFare = 0;
            foreach(var data in ride)
            {
                TotalFare += this.CalculateFare(data.DISTANCE, data.TIME);
            }
           
                return TotalFare;
            }
        public InvoiceSummary CalculateInvoiceSummary(Ride[] ride)
        {
            double totalFare = this.CalculateMultipleRideFare(ride);
            InvoiceSummary summary = new InvoiceSummary();
            summary.totalFare = totalFare;
            summary.totalNumberofRides = ride.Count();
            summary.CalculateAverageFare();
            return summary;
        }
        

    }

}