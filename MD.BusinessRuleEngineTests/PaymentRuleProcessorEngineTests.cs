using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MD.BusinessRuleEngine.Models;
using Moq;
using MD.BusinessRuleEngine.TestHelpers;

namespace MD.BusinessRuleEngine.Tests
{
    [TestClass()]
    public class PaymentRuleProcessorEngineTests
    {
        [TestMethod()]
        public void GetTaskTest()
        {
            var paymentData = new List<CustomerPayment>
            {
                new CustomerPayment
                {
                    CustomerName = "Test Customer1",
                    ForProductType = ProductType.Book,
                    Amount = 400,
                    Description = "Data Structure Usin C"
                },
                new CustomerPayment
                {
                    CustomerName = "Test Customer2",
                    ForProductType = ProductType.NewSubscription,
                    Amount = 600,
                    Description = "Test new Membership 1"
                },
                new CustomerPayment
                {
                    CustomerName = "Test Customer3",
                    ForProductType = ProductType.UpgradeSubscription,
                    Amount = 1000,
                    Description = "Test upgrade Membership"
                },
                new CustomerPayment
                {
                    CustomerName = "Test Customer4",
                    ForProductType = ProductType.Video,
                    Amount = 200,
                    Description = "Learning to Ski"
                }
            };

            var mock = new Mock<PaymentRuleProcessorEngine>();
            mock.Setup(abs => abs.GetPaymentData()).Returns(paymentData);

            IRuleEngine paymentEngine = mock.Object;
            var result = paymentEngine.GetTask();

            Assert.IsNotNull(result);
            Assertx.DoesNotThrowException<Exception>(() => result.Wait());
        } 
    }
}