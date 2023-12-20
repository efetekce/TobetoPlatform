namespace Business.Dtos.Request
{
    public class UpdateAccountApplicationRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int ApplicationId { get; set; }
        public int ApplicationStepId { get; set; }
    }
}
