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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; } //validation: yalnızca sayı değeri girilecek
        public string Email { get; set; } //regex bak validation eklenecek
        public DateTime BirthDate { get; set; } 
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        //public bool Status { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public District District { get; set; }
        public int DistrictId { get; set; }

        public ICollection<AccountExperience> AccountExperience { get; set; }
        public ICollection<AccountEducation> AccountEducation { get; set; }
        public ICollection<AccountSkill> AccountSkill { get; set; }
        public ICollection<AccountCertificate> AccountCertificate { get; set; }
        public ICollection<AccountSocialMedia> AccountSocialMedia { get; set; }
        public ICollection<AccountForeignLanguage> AccountForeignLanguage { get; set; }
        
        //public ICollection<AccountCourse> AccountCourses { get; set; }
        //public ICollection<AccountTestResult> AccountTestResult { get; set; }
        //public string ProfilePhotoPath { get; set; }






    }

}
