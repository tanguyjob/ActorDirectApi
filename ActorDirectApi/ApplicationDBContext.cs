using ActorDirectApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ActorDirectApi
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Candidate>().Property(a => a.BirthDate).HasColumnType("date");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");

        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Corpulence> Corpulence { get; set; }
        public DbSet<Physique> Physique { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Skill> Skill { get; set; }

        public DbSet<CandidateSchool> CandidateSchool { get; set; }
        public DbSet<CandidateSkill> CandidateSkill { get; set; }

    }
}
