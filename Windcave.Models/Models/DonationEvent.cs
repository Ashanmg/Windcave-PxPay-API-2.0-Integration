using System;
using System.Collections.Generic;
using System.Text;

namespace Windcave.Model
{
    public class DonationEvent
    {
        public int DonationEventId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
