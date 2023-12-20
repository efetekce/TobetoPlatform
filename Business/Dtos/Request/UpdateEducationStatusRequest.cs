namespace Business.Dtos.Request
{
    public class UpdateEducationStatusRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
    }
}
