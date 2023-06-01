namespace StudentAPI.DTO
{
    public class AddressDto
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public Guid StudentId { get; set; }
    }
}
}
