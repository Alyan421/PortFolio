namespace WebNexus.Models
{
    public class Social : BaseEntity
    {
        public string? FacebookUrl { get; set; }
        public string? SnapchatUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? GithubUrl { get; set; }
    }
}