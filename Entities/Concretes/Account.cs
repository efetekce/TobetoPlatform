using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Account : Entity<int>
    {
        // public int UserId { get; set; }
        // public int DistrictId { get; set; }
        // public int CityId { get; set; }
        // public int CountryId { get; set; }
        //  public string AdressDetail { get; set; }
        //  public string Description { get; set; }
        public int AddressId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NationalId { get; set; }
        public string? Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ProfilePhotoPath { get; set; }
        public bool Status { get; set; }
        //public virtual District District { get; set; }
        //public virtual City City { get; set; }
        //public virtual Country Country { get; set; }
        //public virtual User User { get; set; }
        //public virtual Address Address { get; set; }
        //public virtual ICollection<Skill>? Skills { get; set; }
        //public virtual ICollection<AccountForeignLanguage>? AccountForeignLanguages { get; set; }
        //public virtual ICollection<AccountSocialMedia>? AccountSocialMedias { get; set; }
        //public virtual ICollection<AccountEducation>? AccountEducations { get; set; }
        //public virtual ICollection<AccountCourse>? AccountCourses { get; set; }
        //public virtual ICollection<AccountCourseLesson>? AccountCoursesLessons { get; set; }
        //public virtual ICollection<AccountCertificate>? AccountCertificates { get; set; }
        //public virtual ICollection<AccountTestResult>? AccountTestResults { get; set; }
        //public virtual ICollection<AccountApplication>? AccountApplications { get; set; }
    }
}
