using System.ComponentModel.DataAnnotations;

namespace SchoolAdmin.Data
{
    public class Subscriber
    {
        public Int64 SubscriberMasterId { get; set; }
        public string SubscroberCode { get; set; }
        public string SubscriberName { get; set; }
        public string SubscriberAddress { get; set; }
        public string Email{ get; set; }
        public string Mobile { get; set; }
    }
}
