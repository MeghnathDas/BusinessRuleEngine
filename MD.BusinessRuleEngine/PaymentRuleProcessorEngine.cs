using MD.BusinessRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.BusinessRuleEngine
{
    public abstract class PaymentRuleProcessorEngine : IRuleEngine
    {
        public abstract ICollection<CustomerPayment> GetPaymentData();

        public Task GetTask()
        {
            return null;
        }
    }
}
