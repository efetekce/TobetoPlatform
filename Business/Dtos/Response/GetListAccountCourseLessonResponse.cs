﻿namespace Business.Dtos.Response
{
    public class GetListAccountCourseLessonResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int LessonId { get; set; }
        public int VideoViewingStatusId { get; set; }
        public bool Like { get; set; }
        public bool IsActive { get; set; }
    }
}
