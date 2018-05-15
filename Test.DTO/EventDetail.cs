using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO
{
    class EventDetail
    {
        public int EventId { get; set; }
        public string EventCode { get; set; }
        public string EventName { get; set; }
        public System.DateTime EventDate { get; set; }
        public string DistanceCategories { get; set; }
        public string EventCity { get; set; }
        public string EventState { get; set; }
        public string EventCountry { get; set; }
        public string EventDetails { get; set; }
        public string EventLocation { get; set; }
        public decimal RegistrationFees { get; set; }
        public string RegistrationLink { get; set; }
    }
}
