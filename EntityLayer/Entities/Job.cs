using EntityLayer.HelperEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Job : Entity
    {
        public string Description { get; set; }
        public string Wage { get; set; }
        private int paymentStyle = (int)PaymentStyle.Hourly;
        public string PaymentType
        {
            set
            {
                if (paymentStyle == 0)
                {
                    PaymentType = "Hourly";
                }
                if (paymentStyle == 1)
                {
                    PaymentType = "Monthly";
                }
                if (paymentStyle == 3)
                {
                    PaymentType = "Numbers of Tasks Solved";
                }
            }
        }

        public string Region { get; set; }
        public AddressInformation Address { get; set; }
        public ContactInformation Contact { get; set; }

    }
}
