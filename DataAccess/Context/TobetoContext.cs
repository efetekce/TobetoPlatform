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
<<<<<<< Updated upstream
=======
        public DbSet<Announcement> Announcements { get; set; }
       
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Skills> Skills { get; set; }

        public DbSet<Certificate> Certificates { get; set; }


        public DbSet<ProfileImage> ProfileImages { get; set; }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======

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
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
            Database.EnsureCreated(); //migration'lar yönetilirken kullanılır.

<<<<<<< Updated upstream


>>>>>>> Stashed changes
=======
            Database.EnsureCreated(); //migration'lar yönetilirken kullanılır.
>>>>>>> Stashed changes
=======
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
