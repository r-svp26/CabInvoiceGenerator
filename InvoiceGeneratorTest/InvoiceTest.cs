using CabInvoiceGenerator;
using NUnit.Framework;

namespace InvoiceGeneratorTest
{
    /// <summary>
    /// NUnit Test class
    /// </summary>
    public class Tests
    {
        InvoiceGenerator invoice;
        [Test]
        public void GivenDistanceTime_ShouldReturnTotalFare()
        {
            //// Creating instance of InvoiceGenerator for Normal
            invoice = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            //// Calculating fare
            double fare = invoice.CalculateFare(distance,time);
            double expected = 25;
            //// Asserting values
            Assert.AreEqual(expected, fare);
        }
    }
}