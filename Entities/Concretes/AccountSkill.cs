using Core.Entities;

namespace Entities.Concretes
{
    public class AccountSkill : Entity<int>
    {
        public int AccountId { get; set; }
        public int SkillId { get; set; }
    }
}
