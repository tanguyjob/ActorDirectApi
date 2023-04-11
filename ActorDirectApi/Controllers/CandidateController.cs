using ActorDirectApi.DTOs;
using ActorDirectApi.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ActorDirectApi.Controllers
{
    [ApiController]
    [Route("api/Candidate")]
    public class CandidateController:ControllerBase
    {
        private readonly ApplicationDBContext context;
        private readonly IMapper mapper;


        public CandidateController(ApplicationDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidate>>> Get()
        {
            return await context.Candidate.ToListAsync();
        }

        //[HttpPost]
        //public async Task<ActionResult> Post(CandidateCreationDTO movieCreationDTO)
        //{
        //    var movie = mapper.Map<Candidate>(movieCreationDTO);

        //    //if (movie.Genres is not null)
        //    //{
        //    //    foreach (var genres in movie.Genres)
        //    //    {
        //    //        context.Entry(genres).State = EntityState.Unchanged;
        //    //    }
        //    //}


        //    context.Add(movie);

        //    await context.SaveChangesAsync();

        //    return Ok();
        //}

        [HttpPost]
        public async Task<ActionResult> Post(CandidateCreationDTO movieCreationDTO)
        {
            var movie = mapper.Map<Candidate>(movieCreationDTO);


            context.Add(movie);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
