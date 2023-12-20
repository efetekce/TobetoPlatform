namespace Business.Dtos.Response
{
    public class UpdatedSessionStatusResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public bool Status { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set; }
    }
}
