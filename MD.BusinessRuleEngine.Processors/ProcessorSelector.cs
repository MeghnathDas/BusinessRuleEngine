using MD.BusinessRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MD.BusinessRuleEngine.Processors.Extension
{
    public static class ProcessorSelector
    {
        private static Dictionary<ProductType, Func<CustomerPayment, IProcessor>> _dicProcessors;
        static ProcessorSelector()
        {
            _dicProcessors = new Dictionary<ProductType, Func<CustomerPayment, IProcessor>> {
                { ProductType.Others, (x) => new PhysicalProductProcessor(x) },
                { ProductType.Book, (x) => new BookPaymentProcessor(x) },
                { ProductType.NewSubscription, (x) => new MembershipPaymentProcessor(x) },
                { ProductType.UpgradeSubscription, (x) => new MembershipUpgradePaymentProcessor(x) }
            };
        }
        public static IProcessor GetProcessor(this CustomerPayment customerPayment)
        {
            return _dicProcessors[customerPayment.ForProductType].Invoke(customerPayment);
        }
    }
}
