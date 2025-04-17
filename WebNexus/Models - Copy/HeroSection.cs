namespace WebNexus.Models
{
    public class HeroSection : BaseEntity
    {
        public string Headline { get; set; }
        public string Subheadline { get; set; }
        public string ImageUrl { get; set; }
        public string? Detail1 { get; set; }
        public string? Detail2 { get; set; }
        public string? Detail3 { get; set; }
        public string ResumeUrl { get; set; }
    }
}
