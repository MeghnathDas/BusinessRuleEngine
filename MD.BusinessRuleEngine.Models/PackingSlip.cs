using System;
using System.Collections.Generic;
using System.Text;

namespace MD.BusinessRuleEngine.Models
{
    public class PackingSlip: ICloneable
    {
        private bool _isDuplicate;
        public bool IsDuplicate => _isDuplicate;
        public PackingSlip() { _isDuplicate = false; }
        private PackingSlip(PackingSlip packingSlip)
        {
            CustomerName = packingSlip.CustomerName;
            Amount = packingSlip.Amount;
            _isDuplicate = true;
        }
        public string CustomerName { get; set; }
        public string[] Items { get; set; }
        public double Amount { get; set; }

        public object Clone()
        {
            return new PackingSlip(this);
        }
    }
}
