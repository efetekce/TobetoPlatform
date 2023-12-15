using Core.Entities;

namespace Entities.Concretes
{
    public class ProfileLanguage:Entity<int>
    {
        public int ProfileId { get; set; }
        public int LanguageId { get; set; }
        public int LanguageLevelId { get; set; }
    }
}
