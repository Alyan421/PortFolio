namespace WebNexus.Models
{
    public class Project : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }// MM/YYYY
        public string EndDate { get; set; } //MM/YYYY
        public string ProjectUrl { get; set; }
    }
}