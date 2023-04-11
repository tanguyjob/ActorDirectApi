namespace ActorDirectApi.DTOs
{
    public class AddressCreationDTO
    {
        public string Country { get; set; }

        public String State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int Street { get; set; }
        public string Number { get; set; }
        public String Telephone { get; set; }

        public String Email { get; set; }
    }
}
