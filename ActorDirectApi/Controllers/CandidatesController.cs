using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ActorDirectApi;
using ActorDirectApi.Entities;
using ActorDirectApi.DTOs;
using AutoMapper;

namespace ActorDirectApi.Controllers
{
    //55
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;

        public CandidatesController(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
        }

        // GET: api/Candidates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetCandidate()
        {
          if (_context.Candidate == null)
          {
              return NotFound();
          }
            return await _context.Candidate.ToListAsync();
        }

        // GET: api/Candidates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidate>> GetCandidate(int id)
        {
          if (_context.Candidate == null)
          {
              return NotFound();
          }
            var candidate = await _context.Candidate.FindAsync(id);

            if (candidate == null)
            {
                return NotFound();
            }

            return candidate;
        }

        // PUT: api/Candidates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCandidate(int id, Candidate candidate)
        {
            if (id != candidate.CandidateId)
            {
                return BadRequest();
            }

            _context.Entry(candidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidateExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Candidates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Candidate>> PostCandidate(Candidate candidate)
        //{
        //  if (_context.Candidate == null)
        //  {
        //      return Problem("Entity set 'ApplicationDBContext.Candidate'  is null.");
        //  }
        //    _context.Candidate.Add(candidate);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCandidate", new { id = candidate.CandidateId }, candidate);
        //}

        //POST: api/Candidates
        //To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult> Post(Candidate candidate)
        //{
        //    if (_context.Candidate == null)
        //    {
        //        return Problem("Entity set 'ApplicationDBContext.Candidate'  is null.");
        //    }
        //    _context.Candidate.Add(candidate);
        //    await _context.SaveChangesAsync();

        //    return Ok();
        //}

        [HttpPost]
        public async Task<ActionResult> Post(CandidateCreationDTO candidateCreationDTO)
        {
            var candidate = _mapper.Map<Candidate>(candidateCreationDTO);
            if (_context.Candidate == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Candidate'  is null.");
            }



            _context.Add(candidate);
            await _context.SaveChangesAsync();

            return Ok();
        }




        //[HttpPost("several")]
        //public async Task<ActionResult> Post(CandidateCreationDTO[] candidateCreationDTO)
        //{
        //    var candidates = _mapper.Map<Candidate[]>(candidateCreationDTO);
        //    //if (_context.Candidate == null)
        //    //{
        //    //    return Problem("Entity set 'ApplicationDBContext.Candidate'  is null.");
        //    //}
        //    _context.Candidate.AddRange(candidates);
        //    await _context.SaveChangesAsync();

        //    return Ok();
        //}

        // DELETE: api/Candidates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCandidate(int id)
        {
            if (_context.Candidate == null)
            {
                return NotFound();
            }
            var candidate = await _context.Candidate.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }

            _context.Candidate.Remove(candidate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CandidateExists(int id)
        {
            return (_context.Candidate?.Any(e => e.CandidateId == id)).GetValueOrDefault();
        }
    }
}
