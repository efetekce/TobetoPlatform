﻿namespace Business.Dtos.Response
{
    public class UpdatedSocialMediaPlatformResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
    }
}
