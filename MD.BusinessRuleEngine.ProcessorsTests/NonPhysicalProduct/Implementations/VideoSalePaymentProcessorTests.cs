using Microsoft.VisualStudio.TestTools.UnitTesting;
using MD.BusinessRuleEngine.Processors;
using System;
using System.Collections.Generic;
using System.Text;
using MD.BusinessRuleEngine.Models;
using Moq;
using MD.BusinessRuleEngine.TestHelpers;

namespace MD.BusinessRuleEngine.Processors.Tests
{
    [TestClass()]
    public class VideoSalePaymentProcessorTests
    {
        private CustomerPayment mockData = new CustomerPayment
        {
            CustomerName = "Test Customer2",
            ForProductType = ProductType.UpgradeSubscription,
            Amount = 800,
            Description = "Test new Membership 1"
        };
        private Mock<VideoSalePaymentProcessor> GetVideoSalePaymentProcessor() =>
            new Mock<VideoSalePaymentProcessor>(mockData);

        [TestMethod()]
        public void GeneratePackingSlipTest()
        {
            var mockVideoSalePaymentProcessor = GetVideoSalePaymentProcessor();
            Assertx.DoesNotThrowException<Exception>(() => mockVideoSalePaymentProcessor.Object.GeneratePackingSlip());
        }
    }
}