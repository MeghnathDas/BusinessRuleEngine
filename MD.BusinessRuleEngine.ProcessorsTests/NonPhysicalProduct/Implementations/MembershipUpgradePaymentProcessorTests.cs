using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MD.BusinessRuleEngine.Models;
using Moq;
using MD.BusinessRuleEngine.TestHelpers;

namespace MD.BusinessRuleEngine.Processors.Tests
{
    [TestClass()]
    public class MembershipUpgradePaymentProcessorTests
    {
        private CustomerPayment mockData = new CustomerPayment
        {
            CustomerName = "Test Customer2",
            ForProductType = ProductType.UpgradeSubscription,
            Amount = 800,
            Description = "Test new Membership 1"
        };
        private Mock<MembershipUpgradePaymentProcessor> GetMockMembershipUpgradePaymentProcessor() =>
            new Mock<MembershipUpgradePaymentProcessor>(mockData);

        [TestMethod()]
        public void UpgradeTest()
        {
            var mockMembershipUpgradePaymentProcessor = GetMockMembershipUpgradePaymentProcessor();
            Assertx.DoesNotThrowException<Exception>(() => mockMembershipUpgradePaymentProcessor.Object.Upgrade());
        }

        [TestMethod()]
        public void SendMailNotificationTest()
        {
            var mockMembershipUpgradePaymentProcessor = GetMockMembershipUpgradePaymentProcessor();
            Assertx.DoesNotThrowException<Exception>(() => mockMembershipUpgradePaymentProcessor.Object.SendMailNotification());
        }
    }
}