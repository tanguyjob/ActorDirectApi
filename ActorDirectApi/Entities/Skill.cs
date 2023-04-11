namespace ActorDirectApi.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }

        public HashSet<CandidateSkill> CandidatesSkills { get; set; } = new HashSet<CandidateSkill>();

    }
}
