using MD.BusinessRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MD.BusinessRuleEngine.Processors
{
    public class MembershipPaymentProcessor : IProcessor, IMembershipPaymentProcessor
    {
        private readonly CustomerPayment _customerPayment;
        public MembershipPaymentProcessor(CustomerPayment customerPayment)
        {
            _customerPayment = customerPayment;
        }
        public void Execute()
        {
            MarkActive();
        }

        public void MarkActive()
        {
            //Membership activation code goes here
        }

        public virtual void SendMailNotification()
        {
            //Mail notification code goes here
        }
    }
}
