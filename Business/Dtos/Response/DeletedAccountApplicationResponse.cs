﻿namespace Business.Dtos.Response
{
    public class DeletedAccountApplicationResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int ApplicationId { get; set; }
        public int ApplicationStepId { get; set; }
    }
}
