using System;
using System.Collections.Generic;
using System.Text;

namespace MD.BusinessRuleEngine.Processors
{
    public interface IMembershipPaymentProcessor
    {
        public void MarkActive();
        public void SendMailNotification();
    }
}
