using Core.Entities;
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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }

        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePhotoPath { get; set; }
        public bool IsActive { get; set; }

    }
}
