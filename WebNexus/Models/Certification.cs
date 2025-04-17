namespace WebNexus.Models
{
    public class Certification : BaseEntity
    {
        public string Title { get; set; }
        public string Issuer { get; set; }
        public string IssuedDate { get; set; }
        public string CertificateLink { get; set; }
        public string Credintials { get; set; }
    }
}