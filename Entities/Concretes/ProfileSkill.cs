using Core.Entities;

namespace Entities.Concretes
{
    public class ProfileSkill:Entity<int>
    {
        public int ProfileId { get; set; }
        public int SkillId { get; set; }
    }
}
