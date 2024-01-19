using Core.Entities;

namespace Entities.Concretes
{
    public class City : Entity<int>
    {
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string Name { get; set; }

        public ICollection<District> Districts { get; set; }

        // Birebir ilişki için dış anahtar
        //public Account Account { get; set; }
        //public AccountExperience AccountExperience { get; set; }
    }
}
