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
            double result = invoice.CalculateFare(5,2);
            Assert.AreEqual(Expected,result);

        }
        [Test]
        public void GivenDistanceAndTime_MultipleRide_WhenClaculate_shouldReturntotalFare()
        {
            InviceGenerator invoice = new InviceGenerator();
            Ride[] rides = { new Ride(5, 2), new Ride(7, 2) };
            double Expected = invoice.CalculateMultipleRideFare(rides);
            double result = invoice.CalculateMultipleRideFare(rides);
            Assert.AreEqual(Expected, result);
        }
    }
}