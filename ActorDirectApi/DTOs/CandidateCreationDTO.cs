namespace ActorDirectApi.DTOs
{
    public class CandidateCreationDTO
    {
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<CandidateSkillCreationDTO> CandidatesSkills { get; set; } = new List<CandidateSkillCreationDTO>();
    }

    public class CandidateSkillCreationDTO
    {
        
        public int SkillId { get; set; }
    }
}
