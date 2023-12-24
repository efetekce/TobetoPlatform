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
        public int AdressId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NationalId { get; set; }
        public string? Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ProfilePhotoPath { get; set; }
        public bool Status { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<AccountForeignLanguage> AccountForeignLanguages { get; set; }
        //public ICollection<AccountSocialMedia> AccountSocialMedias { get; set; }
        public ICollection<AccountEducation> AccountEducations { get; set; }
        public ICollection<AccountCourse> AccountCourses { get; set; }
        public ICollection<AccountCourseLesson> AccountCoursesLessons { get; set; }
        public ICollection<AccountCertificate> AccountCertificates { get; set; }
        public ICollection<AccountTestResult> AccountTestResult { get; set; }
        public ICollection<Address> Address { get; set; }






    }

}
