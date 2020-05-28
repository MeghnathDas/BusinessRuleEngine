﻿using MD.BusinessRuleEngine.Models;
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
            };
        }
        public static IProcessor GetProcessor(this CustomerPayment customerPayment)
        {
            return _dicProcessors[customerPayment.ForProductType].Invoke(customerPayment);
        }
    }
}