namespace Business.Dtos.Response
{
    public class UpdatedAccountSocialMediaResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SocialMediaId { get; set; }
        public int Priority { get; set; }
        public string Link { get; set; }
    }
}
