namespace Business.Dtos.Request
{
    public class UpdateMembershipStatusRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public bool Status { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
