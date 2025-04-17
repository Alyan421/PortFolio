using WebNexus.Models;

public class PersonalInfo : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string? ImageUrl { get; set; }
}