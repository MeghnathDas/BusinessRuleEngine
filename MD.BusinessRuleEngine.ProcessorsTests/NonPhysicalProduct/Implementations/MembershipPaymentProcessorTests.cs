using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using MD.BusinessRuleEngine.Models;
using MD.BusinessRuleEngine.TestHelpers;

namespace MD.BusinessRuleEngine.Processors.Tests
{
    [TestClass()]
    public class MembershipPaymentProcessorTests
    {
        private CustomerPayment mockData = new CustomerPayment
        {
            CustomerName = "Test Customer2",
            ForProductType = ProductType.NewSubscription,
            Amount = 600,
            Description = "Test new Membership 1"
        };
        private Mock<MembershipPaymentProcessor> GetMockMembershipPaymentProcessor() =>
            new Mock<MembershipPaymentProcessor>(mockData);

        [TestMethod()]
        public void MarkActiveTest()
        {
            var mockMembershipPaymentProcessor = GetMockMembershipPaymentProcessor();
            Assertx.DoesNotThrowException<Exception>(() => mockMembershipPaymentProcessor.Object.MarkActive());
        }

        [TestMethod()]
        public void SendMailNotificationTest()
        {
            var mockMembershipPaymentProcessor = GetMockMembershipPaymentProcessor();
            Assertx.DoesNotThrowException<Exception>(() => mockMembershipPaymentProcessor.Object.SendMailNotification());
        }
    }
}