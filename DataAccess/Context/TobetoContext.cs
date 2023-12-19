using Core.Entities.Concrete;
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

<<<<<<< Updated upstream
        public DbSet<Language> Languages { get; set; }

<<<<<<< Updated upstream
=======
        public DbSet<Announcement> Announcements { get; set; }
       
>>>>>>> Stashed changes
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Skills> Skills { get; set; }

        public DbSet<Certificate> Certificates { get; set; }
=======
        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Skills> Skills { get; set; }

        public DbSet<ProfileImage> ProfileImages { get; set; }
<<<<<<< Updated upstream
>>>>>>> Stashed changes
        public DbSet<PlatformCatalog> PlatformCatalogs { get; set; }
=======
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }

>>>>>>> Stashed changes


        public TobetoContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            Database.EnsureCreated(); //migration'lar yönetilirken kullanılır.
=======
            Database.EnsureCreated();



>>>>>>> Stashed changes
=======
            Database.EnsureCreated(); //migration'lar yönetilirken kullanılır.
>>>>>>> Stashed changes
        }

        public TobetoContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
