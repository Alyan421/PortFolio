namespace WebNexus.Models
{
    public class Testimonial : BaseEntity
    {
        public string Quote { get; set; }
        public string ClientName { get; set; }
        public string ClientTitle { get; set; }
        public string ClientCompany { get; set; }
        public string? PhotoUrl { get; set; }
    }
}