using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class TobetoContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PersonalInformation> PersonalInformation { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<ProfileImage> ProfileImages { get; set; }
        public DbSet<PlatformCatalog> PlatformCatalogs { get; set; }

        public TobetoContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
            Database.EnsureCreated(); //migration'lar yönetilirken kullanılır.
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
