﻿namespace Business.Dtos.Response
{
    public class DeletedEducationProgramResponse
    {
        public int Id { get; set; }
        public int UniversityId { get; set; }
        public string Name { get; set; }
        public bool Visibility { get; set; }
    }
}
