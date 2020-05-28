using System;
using System.Collections.Generic;
using System.Text;

namespace MD.BusinessRuleEngine.Models
{
    public enum ProductType { Book, NewSubscription, UpgradeSubscription, Video, Others }
    public class CustomerPayment: Payment
    {
        public string CustomerName { get; set; }
        public ProductType ForProductType { get; set; }
    }
}
