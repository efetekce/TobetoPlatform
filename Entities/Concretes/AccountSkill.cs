using Core.Entities;

namespace Entities.Concretes
{
    public class AccountSkill : Entity<int>
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public ICollection<Skill> Skill { get; set; }
    }
}
