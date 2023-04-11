using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActorDirectApi.Entities.Configurations
{
    public class CandidateSchoolConfig : IEntityTypeConfiguration<CandidateSchool>
    {
        public void Configure(EntityTypeBuilder<CandidateSchool> builder)
        {
            builder.HasKey(cs => new { cs.SchoolId, cs.CandidateId });
        }
    }
}
