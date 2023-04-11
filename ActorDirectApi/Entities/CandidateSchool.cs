namespace ActorDirectApi.Entities
{
    public class CandidateSchool
    {
        public int CandidateId { get; set; }

        public int SchoolId { get; set; }

        public DateTime Date { get; set; }

        public Candidate Candidate { get; set; }
        public School School { get; set; }


    }
}
