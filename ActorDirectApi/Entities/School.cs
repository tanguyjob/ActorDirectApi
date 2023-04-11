namespace ActorDirectApi.Entities
{
    public class School
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }

        public String Area { get; set; }


        public List<CandidateSchool> CandidateSchool { get; set; } = new List<CandidateSchool>();
    }
}
