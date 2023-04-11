using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActorDirectApi.Entities.Configurations
{
    public class CandidateSkillConfig : IEntityTypeConfiguration<CandidateSkill>
    {
        public void Configure(EntityTypeBuilder<CandidateSkill> builder)
        {
            builder.HasKey(cs => new { cs.SkillId, cs.CandidateId });
        }
    }
}
