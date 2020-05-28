using MD.BusinessRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MD.BusinessRuleEngine.Processors.Extension;

namespace MD.BusinessRuleEngine
{
    public abstract class PaymentRuleProcessorEngine : IRuleEngine
    {
        public abstract ICollection<CustomerPayment> GetPaymentData();

        public Task GetTask()
        {
            return Task.WhenAll(
                GetPaymentData().Select(pmnt =>
                    Task.Run(() => pmnt.GetProcessor().Execute())
                    )
                );
        }
    }
}
