namespace Business.Dtos.Response
{
    public class CreatedAccountSocialMediaResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SocialMediaPlatformId { get; set; }
        public string Link { get; set; }
    }
}
