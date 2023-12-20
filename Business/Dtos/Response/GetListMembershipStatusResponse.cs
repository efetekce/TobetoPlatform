﻿namespace Business.Dtos.Response
{
    public class GetListMembershipStatusResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public bool Status { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
