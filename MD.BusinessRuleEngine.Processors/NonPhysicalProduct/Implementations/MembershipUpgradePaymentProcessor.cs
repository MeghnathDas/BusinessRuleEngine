using MD.BusinessRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MD.BusinessRuleEngine.Processors
{
    public class MembershipUpgradePaymentProcessor: MembershipPaymentProcessor, IMembershipUpgradePaymentProcessor
    {
        public MembershipUpgradePaymentProcessor(CustomerPayment customerPayment): base(customerPayment)
        {
        }

        public new void Execute()
        {
            base.Execute();
            Upgrade();
            SendMailNotification();
        }
        public void Upgrade()
        {
            //Membership upgradation code goes here
        }
        public override void SendMailNotification()
        {
            //Membership upgrade notification implementation goes here
        }
    }
}
