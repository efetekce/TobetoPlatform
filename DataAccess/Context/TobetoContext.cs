using Business.Dtos.Request;
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
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<ForeignLanguage> Languages { get; set; }
        public DbSet<PersonalInformation> PersonalInformation { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<ProfileImage> ProfileImages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CourseContent> CourseContents { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }
        public DbSet<ForeignLanguageLevel> ForeignLanguagesLevels { get; set; }
        public DbSet<AccountForeignLanguage> AccountForeignLanguages { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseContentType> CourseContentTypes { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<AccountCourse> AccountCourses { get; set; }
        public DbSet<AccountCourseLesson> AccountCourseLesson { get; set; }




        public TobetoContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;

            Database.EnsureCreated();

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
