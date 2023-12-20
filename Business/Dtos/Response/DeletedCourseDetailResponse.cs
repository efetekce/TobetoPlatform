﻿namespace Business.Dtos.Response
{
    public class DeletedCourseDetailResponse
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int CourseContentId { get; set; }
        public int CategoryId { get; set; }
        public int OrganizationId { get; set; }
        public string Language { get; set; }
        public string SubType { get; set; }
    }
}
