namespace Business.Dtos.Request
{
    public class CreateAccountSocialMediaRequest
    {
        public int AccountId { get; set; }
        public int SocialMediaId { get; set; }
        public int Priority { get; set; }
        public string Link { get; set; }
    }
}
