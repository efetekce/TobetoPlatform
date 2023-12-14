namespace Business.Dtos.Request
{
    public class UpdateCertitificateRequest
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string? CertificateName { get; set; }

    }
}
