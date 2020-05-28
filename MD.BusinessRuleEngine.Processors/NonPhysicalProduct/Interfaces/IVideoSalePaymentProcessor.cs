using MD.BusinessRuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MD.BusinessRuleEngine.Processors
{
    public interface IVideoSalePaymentProcessor
    {
        void GeneratePackingSlip();

    }
}
