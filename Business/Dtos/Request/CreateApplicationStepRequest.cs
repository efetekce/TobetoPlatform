namespace Business.Dtos.Request
{
    public class CreateApplicationStepRequest
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
    }
}
