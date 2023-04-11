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
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper mapper;

        public SkillsController(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: api/Skills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Skill>>> GetSkill()
        {
          if (_context.Skill == null)
          {
              return NotFound();
          }
            return await _context.Skill.ToListAsync();
        }

        // GET: api/Skills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Skill>> GetSkill(int id)
        {
          if (_context.Skill == null)
          {
              return NotFound();
          }
            var skill = await _context.Skill.FindAsync(id);

            if (skill == null)
            {
                return NotFound();
            }

            return skill;
        }

        // PUT: api/Skills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkill(int id, Skill skill)
        {
            if (id != skill.SkillId)
            {
                return BadRequest();
            }

            _context.Entry(skill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillExists(id))
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

        // POST: api/Skills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Skill>> PostSkill(Skill skill)
        //{
        //  if (_context.Skill == null)
        //  {
        //      return Problem("Entity set 'ApplicationDBContext.Skill'  is null.");
        //  }
        //    _context.Skill.Add(skill);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSkill", new { id = skill.SkillId }, skill);
        //}



        // POST: api/Skills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> Post(SkillCreationDTO skillCreationDTO)
        {
            var skill = mapper.Map<Skill>(skillCreationDTO);


            //if (_context.Skill == null)
            //{
            //    return Problem("Entity set 'ApplicationDBContext.Skill'  is null.");
            //}
            _context.Skill.Add(skill);
            await _context.SaveChangesAsync();
            return Ok();
            //return CreatedAtAction("GetSkill", new { id = skill.SkillId }, skill);
        }


        // DELETE: api/Skills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            if (_context.Skill == null)
            {
                return NotFound();
            }
            var skill = await _context.Skill.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }

            _context.Skill.Remove(skill);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkillExists(int id)
        {
            return (_context.Skill?.Any(e => e.SkillId == id)).GetValueOrDefault();
        }
    }
}
