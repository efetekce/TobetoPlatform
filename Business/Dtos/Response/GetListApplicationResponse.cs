﻿namespace Business.Dtos.Response
{
    public class GetListApplicationResponse
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
