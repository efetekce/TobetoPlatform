namespace Business.Dtos.Request
{
    public class CreateSurveyTypeRequest
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
    }
}
