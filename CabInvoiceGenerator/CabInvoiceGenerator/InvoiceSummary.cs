using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
   public class InvoiceSummary
    {
        public int totalNumberofRides { get; set; }
        public double totalFare { get; set; }
        public double averageFarePerRide { get; set; }
        public void CalculateAverageFare()
        {
            averageFarePerRide = totalFare / totalNumberofRides;
        }
    }
}
