﻿using Core.Entities;

namespace Entities.Concretes
{
    public class Country : Entity<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<City> Cities { get; set; }

        // Birebir ilişki için dış anahtar
        //public Account Account { get; set; }
    }
}
