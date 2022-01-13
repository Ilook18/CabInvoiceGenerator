using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        [Test]
        public void GivenDistanceAndTime_WhenACalculate_shoouldReturntotalFare()
        {
            InviceGenerator invoice = new InviceGenerator();
            double Expected = 52;
            double result = invoice.CalculateFare(5, 2);
            Assert.AreEqual(Expected, result);

        }
        [Test]
        public void GivenDistanceAndTime_MultipleRide_WhenClaculate_shouldReturntotalFare()
        {
            InviceGenerator invoice = new InviceGenerator();
            Ride[] rides = { new Ride(5, 2), new Ride(7, 2) };
            double Expected = 124;
            double result = invoice.CalculateMultipleRideFare(rides);
            Assert.AreEqual( result,Expected);
        }
        [Test]
        public void GivenSummary_WhenCalculate_shouldReturntotalFare()
        {
            InviceGenerator invoice = new InviceGenerator();
            Ride[] rides = { new Ride(5, 2), new Ride(7, 2) };
            InvoiceSummary result = invoice.CalculateInvoiceSummary(rides);
            InvoiceSummary summary = new InvoiceSummary();
            summary.totalFare = 124;
            summary.totalNumberofRides = 2;
            summary.CalculateAverageFare();
            if(result.totalFare == summary.totalFare && result.totalNumberofRides == summary.totalNumberofRides && summary.averageFarePerRide == result.averageFarePerRide) 
            {
                Assert.IsTrue(true);
            } 
            else
            {
                Assert.IsTrue(false);
            }

        }
    }
}