using System;
using System.Collections.Generic;
using System.Text;

namespace Windcave.Model
{
    public class DonationPayment
    {
        public int PaymentId { get; set; }
        public string requestXml { get; set; }
        public string ResponseXml { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public int DonationId { get; set; }
        public Donation Donation { get; set; }
    }
}
