using Microsoft.VisualStudio.TestTools.UnitTesting;
using MD.BusinessRuleEngine.Processors.Extension;
using System;
using System.Collections.Generic;
using System.Text;
using MD.BusinessRuleEngine.Models;

namespace MD.BusinessRuleEngine.Processors.Extension.Tests
{
    [TestClass()]
    public class ProcessorSelectorTests
    {
        [TestMethod()]
        public void GetProcessorTest()
        {
            var paymentData = new CustomerPayment
            {
                Amount = 10,
                CustomerName = "Test Customer 1",
                Description = "Test Description 1",
                ForProductType = ProductType.Book
            };

            //var bookProcessor = paymentData.GetProcessor();
            //Assert.IsNotNull(bookProcessor);

            paymentData.ForProductType = ProductType.Others;
            var otherTypOfPhysicalProductPaymentProcessor = paymentData.GetProcessor();
            Assert.IsInstanceOfType(otherTypOfPhysicalProductPaymentProcessor, typeof(IPhysicalProductPaymentProcessor));
        }
    }
}