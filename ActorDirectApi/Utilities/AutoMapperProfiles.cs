using ActorDirectApi.DTOs;
using ActorDirectApi.Entities;
using AutoMapper;

namespace ActorDirectApi.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CandidateCreationDTO, Candidate>();
            CreateMap<SkillCreationDTO, Skill>();
            CreateMap<CandidateSkillCreationDTO, CandidateSkill>();

            
        }
    }
}
