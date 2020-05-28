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
    public class PhysicalProductProcessorTests
    {
        private CustomerPayment mockData = new CustomerPayment
        {
            CustomerName = "Test Customer2",
            ForProductType = ProductType.Others,
            Amount = 100,
            Description = "Other Item"
        };
        private Mock<PhysicalProductProcessor> GetPhysicalProductProcessor() =>
            new Mock<PhysicalProductProcessor>(mockData);

        [TestMethod()]
        public void GeneratePackingSlipTest()
        {
            var mockPhysicalProductProcessor = GetPhysicalProductProcessor();
            Assertx.DoesNotThrowException<Exception>(() => mockPhysicalProductProcessor.Object.GeneratePackingSlip());
        }

        [TestMethod()]
        public void GenerateAgentPaymentTest()
        {
            var mockPhysicalProductProcessor = GetPhysicalProductProcessor();
            Assertx.DoesNotThrowException<Exception>(() => mockPhysicalProductProcessor.Object.GenerateAgentPayment());
        }
    }
}