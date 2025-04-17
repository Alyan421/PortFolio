using Microsoft.EntityFrameworkCore;
using WebNexus.Models;

namespace WebNexus.EntityFrameworkCore
{
    public class AMSDbContext : DbContext
    {
        public AMSDbContext(DbContextOptions<AMSDbContext> options) : base(options)
        {

        }

        // DbSet properties for all models
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<ProjectTestimonial> ProjectTestimonials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // HeroSection
            modelBuilder.Entity<HeroSection>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(h => h.Headline).IsRequired().HasMaxLength(200);
                entity.Property(h => h.Subheadline).HasMaxLength(200);
                entity.Property(h => h.ImageUrl).HasMaxLength(500);
                entity.Property(h => h.ResumeUrl).HasMaxLength(500);
            });

            // Achievement
            modelBuilder.Entity<Achievement>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Title).IsRequired().HasMaxLength(150);
                entity.Property(a => a.Description).HasMaxLength(500);
                entity.Property(a => a.Date).HasMaxLength(50);
            });

            // Certification
            modelBuilder.Entity<Certification>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Title).IsRequired().HasMaxLength(150);
                entity.Property(c => c.Issuer).HasMaxLength(100);
                entity.Property(c => c.IssuedDate).HasMaxLength(50);
                entity.Property(c => c.CertificateLink).HasMaxLength(500);
                entity.Property(c => c.Credintials).HasMaxLength(500);
            });

            // ContactMessage
            modelBuilder.Entity<ContactMessage>(entity =>
            {
                entity.HasKey(cm => cm.Id);
                entity.Property(cm => cm.Name).IsRequired().HasMaxLength(100);
                entity.Property(cm => cm.Subject).HasMaxLength(200);
                entity.Property(cm => cm.Email).IsRequired().HasMaxLength(150);
                entity.Property(cm => cm.Message).IsRequired().HasMaxLength(1000);
                entity.Property(cm => cm.SentAt).HasMaxLength(50);
            });

            // PersonalInfo
            modelBuilder.Entity<PersonalInfo>(entity =>
            {
                entity.HasKey(pi => pi.Id);
                entity.Property(pi => pi.Name).IsRequired().HasMaxLength(100);
                entity.Property(pi => pi.Email).IsRequired().HasMaxLength(150);
                entity.Property(pi => pi.Phone).HasMaxLength(20);
                entity.Property(pi => pi.ImageUrl).HasMaxLength(500);
            });

            // Project
            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Title).IsRequired().HasMaxLength(150);
                entity.Property(p => p.Description).HasMaxLength(1000);
                entity.Property(p => p.StartDate).HasMaxLength(10); // MM/YYYY
                entity.Property(p => p.EndDate).HasMaxLength(10);   // MM/YYYY
                entity.Property(p => p.ProjectUrl).HasMaxLength(500);
            });

            // Service
            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Name).IsRequired().HasMaxLength(100);
                entity.Property(s => s.Description).HasMaxLength(500);
                entity.Property(s => s.Price).HasColumnType("decimal(18,2)");
            });

            // Testimonial
            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Quote).IsRequired().HasMaxLength(1000);
                entity.Property(t => t.ClientName).IsRequired().HasMaxLength(100);
                entity.Property(t => t.ClientTitle).HasMaxLength(100);
                entity.Property(t => t.ClientCompany).HasMaxLength(100);
                entity.Property(t => t.PhotoUrl).HasMaxLength(500);
            });

            // Social
            modelBuilder.Entity<Social>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.FacebookUrl).HasMaxLength(500);
                entity.Property(s => s.SnapchatUrl).HasMaxLength(500);
                entity.Property(s => s.InstagramUrl).HasMaxLength(500);
                entity.Property(s => s.LinkedInUrl).IsRequired().HasMaxLength(500);
                entity.Property(s => s.TwitterUrl).HasMaxLength(500);
                entity.Property(s => s.GithubUrl).HasMaxLength(500);
            });

            // ProjectTestimonial
            modelBuilder.Entity<ProjectTestimonial>(entity =>
            {
                entity.HasKey(pt => pt.Id);
                entity.Property(pt => pt.Quote).IsRequired().HasMaxLength(1000);
                entity.Property(pt => pt.ClientName).IsRequired().HasMaxLength(100);
                entity.Property(pt => pt.ClientPosition).HasMaxLength(100);
                entity.Property(pt => pt.ClientCompany).HasMaxLength(100);
                entity.Property(pt => pt.ImageUrl).HasMaxLength(500);
            });
        }

    }
}
