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
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<QuestionCategory> QuestionCategories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<ForeignLanguage> Languages { get; set; }
        public DbSet<PersonalInformation> PersonalInformation { get; set; }
        public DbSet<SocialMediaPlatform> SocialMedias { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<ProfileImage> ProfileImages { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AccountPassword> AccountPasswords { get; set; }
        public DbSet<SessionStatus> SessionStatuses { get; set; }
        public DbSet<MembershipStatus> MembershipStatuses { get; set; }
        public DbSet<SocialMediaPlatform> SocialMediaPlatforms { get; set; }
        public DbSet<AccountSocialMedia> AccountSocialMedias { get; set; }
        public DbSet<EducationStatus> EducationStatuses { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<EducationProgram> EducationPrograms { get; set; }
        public DbSet<AccountEducation> AccountEducations { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyType> SurveyTypes { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<AccountApplication> AccountApplications { get; set; }
        public DbSet<ApplicationStep> ApplicationSteps { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }
        public DbSet<ForeignLanguageLevel> ForeignLanguagesLevels { get; set; }
        public DbSet<AccountForeignLanguage> AccountForeignLanguages { get; set; }


        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseContent> CourseContents { get; set; }
        public DbSet<CourseContentType> CourseContentTypes { get; set; }        
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<AccountCourse> AccountCourses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonStatus> LessonStates { get; set; }
        public DbSet<AccountCourseLesson> AccountCourseLesson { get; set; }

        public DbSet<AccountCertificate> AccountCertificates { get; set; }

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
