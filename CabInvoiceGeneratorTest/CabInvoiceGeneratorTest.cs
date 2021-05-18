using NUnit.Framework;
using Cab_Invoice_Generator;
namespace CabInvoiceGeneratorTest
{
     class CabInvoiceGeneratorTest
    {
        private CabInvoiceGenerator cabInvoiceGenerator;

        [SetUp]
        public void Setup() //SetUp Method.
        {
            this.cabInvoiceGenerator = new CabInvoiceGenerator();
        }
        /* UC1.1:-  Test Method for calculating fare when fare is greater than minimum fare.
         */
        [Test] 
        public void GivenDistanceAndTime_FareGreaterThanMinimumFareShouldReturnFare() //create method to calculate greater than minimum fare
        {
            double distance = 10.0; //declare distance veriable and value  // totalFare = (distance * CostPerKilometer) + (time * CostPerMinute);
            double time = 10;    //declare time veriable and value    // (10.0 * 10.0) + (10 * 1.0)= 110
            double expected = 110; //total fare
            double totalFare = this.cabInvoiceGenerator.CalculateFare(distance, time); //call method and passing value
            Assert.AreEqual(expected, totalFare); //check equal or not
        }

        /*UC1.2:- Test Method for calculating fare when fare is less than minimum fare.
         */
        [Test] 
        public void GivenDistanceAndTime_WhenTotalFareIsLessThanMinimumFare_ShouldReturnMinimumFare() //create method to print minimum fare
        {
            double distance = 0.1;
            double time = 1;             // (0.1 * 10.0) + (1 * 1.0)=2
           double MinimumFare=5.0;      //total fare
            double totalFare = this.cabInvoiceGenerator.CalculateFare(distance, time);  //call method and passing value
            Assert.AreEqual(MinimumFare, totalFare); // check equal or not
        }
    }
}