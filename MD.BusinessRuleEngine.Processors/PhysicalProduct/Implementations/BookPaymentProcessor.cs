using MD.BusinessRuleEngine.Processors;
using MD.BusinessRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MD.BusinessRuleEngine.Processors
{
    public class BookPaymentProcessor : PhysicalProductProcessor, IBookPaymentProcessor
    {
        public BookPaymentProcessor(CustomerPayment customerPayment) :base(customerPayment)
        {
        }
        public new void Execute()
        {
            base.Execute();
            GenerateSlipForRoyaltyDep();
        }
        public override void GenerateAgentPayment()
        {
            //Custom agent commision
            ProcessAgentPayment(new Payment { Amount = base._customerPayment.Amount * .1 });
        }
        public void GenerateSlipForRoyaltyDep()
        {
            var duplicatePackingSlip = getPackingslip();
            //Packaging slip storgage call implementation goes here
        }
    }
}
