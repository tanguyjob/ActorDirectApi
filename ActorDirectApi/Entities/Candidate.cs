using System.Diagnostics;

namespace ActorDirectApi.Entities
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public DateTime BirthDate { get; set; }


        //public List<CandidateSchool> CandidateSchool { get; set; } = new List<CandidateSchool>();
        public List<CandidateSkill> CandidatesSkills { get; set; } = new List<CandidateSkill>();

    }
}
