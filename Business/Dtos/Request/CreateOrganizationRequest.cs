namespace Business.Dtos.Request
{
    public class CreateOrganizationRequest
    {
        public int AddressId { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
    }
}
