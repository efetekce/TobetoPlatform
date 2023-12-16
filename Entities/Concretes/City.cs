using Core.Entities;

namespace Entities.Concretes
{
    public class City : Entity<int>
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
    }
}
