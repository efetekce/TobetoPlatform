namespace Business.Dtos.Request
{
    public class CreateSocialMediaPlatformRequest
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
    }
}
