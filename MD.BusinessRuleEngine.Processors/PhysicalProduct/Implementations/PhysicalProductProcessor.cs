using MD.BusinessRuleEngine.Models;

namespace MD.BusinessRuleEngine.Processors
{
    public class PhysicalProductProcessor : IPhysicalProductPaymentProcessor, IProcessor
    {
        protected readonly CustomerPayment _customerPayment;
        public PhysicalProductProcessor(CustomerPayment customerPayment)
        {
            _customerPayment = customerPayment;
        }
        public void Execute()
        {
            GenerateAgentPayment();
            GeneratePackingSlip();
        }

        public virtual void GenerateAgentPayment()
        {
            //By default agent commision is 5 percent 
            ProcessAgentPayment(new Payment { Amount = _customerPayment.Amount * .05 });
        }

        protected void ProcessAgentPayment(Payment agentPayment)
        {
            //Agent payment Code goes here
        }

        internal PackingSlip getPackingslip() => new PackingSlip
            {
                Amount = _customerPayment.Amount,
                CustomerName = _customerPayment.CustomerName
            };

        public void GeneratePackingSlip()
        {
            var packingSlip = getPackingslip();
            //Packaging slip storgage call implementation goes here
        }
    }
}