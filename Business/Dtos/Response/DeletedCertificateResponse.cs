﻿namespace Business.Dtos.Response
{
    public class DeletedCertificateResponse
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string? CertificateName { get; set; }
    }
}