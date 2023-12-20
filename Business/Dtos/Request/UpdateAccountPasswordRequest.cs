namespace Business.Dtos.Request
{
    public class UpdateAccountPasswordRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int Priority { get; set; }
    }
}
