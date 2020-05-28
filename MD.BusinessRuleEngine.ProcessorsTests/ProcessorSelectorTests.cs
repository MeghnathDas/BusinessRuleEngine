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
                ForProductType = ProductType.Others
            };

            CheckProcessor<IPhysicalProductPaymentProcessor>(paymentData);

            paymentData.ForProductType = ProductType.Book;
            CheckProcessor<IBookPaymentProcessor>(paymentData);

            paymentData.ForProductType = ProductType.NewSubscription;
            CheckProcessor<IMembershipPaymentProcessor>(paymentData);

            paymentData.ForProductType = ProductType.UpgradeSubscription;
            CheckProcessor<IMembershipUpgradePaymentProcessor>(paymentData);

            paymentData.ForProductType = ProductType.Video;
            CheckProcessor<IVideoSalePaymentProcessor>(paymentData);
        }
        private void CheckProcessor<TProcessorType>(CustomerPayment paymentData) {
            var processor = paymentData.GetProcessor();
            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(TProcessorType));
        }
    }
}