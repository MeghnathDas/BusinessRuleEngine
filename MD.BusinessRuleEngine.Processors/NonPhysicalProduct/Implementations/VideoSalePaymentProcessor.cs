using MD.BusinessRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MD.BusinessRuleEngine.Processors
{
    public class VideoSalePaymentProcessor : IProcessor, IVideoSalePaymentProcessor
    {
        private readonly CustomerPayment _customerPayment;
        public VideoSalePaymentProcessor(CustomerPayment customerPayment)
        {
            _customerPayment = customerPayment;
        }
        public void Execute()
        {
            GeneratePackingSlip();
        }

        public void GeneratePackingSlip()
        {
            var itms = new List<string>
                {
                    _customerPayment.Description
                };
            if (itms.First().ToLower().Equals("Learning to Ski"))
                itms.Add("The result of a court decision in 1997");

            var pkgSlip = new PackingSlip
            {
                Amount = _customerPayment.Amount,
                CustomerName = _customerPayment.CustomerName,
                Items = itms.ToArray()
            };

            //Packaging slip storgage call implementation goes here
        }
    }
}
