using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly LostFoundContext _context;

        public RegisterController(LostFoundContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetPessoa()
        {

        }

        //// GET: api/Register
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoas()
        //{
        //    return await _context.Pessoas.ToListAsync();
        //}

        //// GET: api/Register/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Pessoa>> GetPessoa(int id)
        //{
        //    var pessoa = await _context.Pessoas.FindAsync(id);

        //    if (pessoa == null)
        //    {
        //        return NotFound();
        //    }

        //    return pessoa;
        //}

        //// PUT: api/Register/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPessoa(int id, Pessoa pessoa)
        //{
        //    if (id != pessoa.pesCod)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(pessoa).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PessoaExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Register
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa(Pessoa pessoa)
        {
            bool sucesso = false;

            try
            {

                pessoa.pesDtaCad = DateTime.Now;
                _context.Pessoas.Add(pessoa);
                await _context.SaveChangesAsync();

                sucesso = true;

            }
            catch (Exception ex)
            {
                return BadRequest(sucesso);
            }            

            return Ok(sucesso);
        }

        //// DELETE: api/Register/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Pessoa>> DeletePessoa(int id)
        //{
        //    var pessoa = await _context.Pessoas.FindAsync(id);
        //    if (pessoa == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Pessoas.Remove(pessoa);
        //    await _context.SaveChangesAsync();

        //    return pessoa;
        //}

        //private bool PessoaExists(int id)
        //{
        //    return _context.Pessoas.Any(e => e.pesCod == id);
        //}

    }
}
