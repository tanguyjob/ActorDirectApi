﻿namespace ActorDirectApi.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Country { get; set; }

        public String State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int Street { get; set; }
        public string Number { get; set; }
        public String Telephone { get; set; }

        public String Email { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

  
    }
}
