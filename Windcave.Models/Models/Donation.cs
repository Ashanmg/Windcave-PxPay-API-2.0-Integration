using System;
using System.Collections.Generic;
using System.Text;

namespace Windcave.Model
{
    public class Donation
    {
        public int DonationId { get; set; }
        public string DonorName { get; set; }
        public decimal Amount { get; set; }
        public string Email { get; set; }
        public string Reason { get; set; }
        public DateTime? DonatedDate { get; set; }

        public int DonationEventId { get; set; }
        public DonationEvent DonationEvent { get; set; }
    }
}
