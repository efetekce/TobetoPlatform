﻿namespace Business.Dtos.Response
{
    public class CreatedOrganizationResponse
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
    }
}
