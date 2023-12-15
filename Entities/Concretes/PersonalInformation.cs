using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class PersonalInformation:Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalIdentity { get; set; }
        public string Email { get; set; }
        public string Country { get; set; } //table
        public string City { get; set; } //table
        public string District { get; set; }
        public string NeighborhoodStreet { get; set; }
        public string AboutMe { get; set; }
    }

}
