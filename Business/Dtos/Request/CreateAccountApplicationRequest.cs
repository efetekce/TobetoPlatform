namespace Business.Dtos.Request
{
    public class CreateAccountApplicationRequest
    {
        public int AccountId { get; set; }
        public int ApplicationId { get; set; }
        public int ApplicationStepId { get; set; }
    }
}
