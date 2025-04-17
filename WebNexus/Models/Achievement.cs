namespace WebNexus.Models
{
    public class Achievement : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; } // MM/YYYY
    }
}