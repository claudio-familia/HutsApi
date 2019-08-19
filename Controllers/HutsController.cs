using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HutsApi.Models;
using System.Net;
using HutsApi.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNet.OData;

namespace HutsApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [EnableQuery()]
    //[Authorize]
    public class HutsController : ControllerBase
    {
        private readonly HutsContext _context;

        public HutsController(HutsContext context)
        {
            _context = context;
        }

        // GET: api/Huts
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<Hut>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.NotAcceptable)]        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hut>>> GetHuts(string sortBy, string searchString, int? pageIndex)
        {
            IQueryable<Hut> HutIQ = from c in _context.Huts
                                           select c;

            //Searching (non case-sensitive)
            if (!String.IsNullOrEmpty(searchString))
            {
                HutIQ = HutIQ.Where(s => s.Name.ToUpper().Contains(searchString.ToUpper())
                                       || s.Address.ToUpper().Contains(searchString.ToUpper()));
            }
            //Sorting
            switch (sortBy)
            {
                case "name":
                    HutIQ = HutIQ.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    HutIQ = HutIQ.OrderByDescending(s => s.Name);
                    break;
                case "address":
                    HutIQ = HutIQ.OrderBy(s => s.Address);
                    break;
                case "address_desc":
                    HutIQ = HutIQ.OrderByDescending(s => s.Address);
                    break;
                default:
                    HutIQ = HutIQ.OrderBy(s => s.Id);
                    break;
            }
            //Paging
            int pageSize = 10;
            var paginatedResult = await PaginatedList<Hut>.CreateAsync(
                HutIQ, pageIndex ?? 1, pageSize);
            return paginatedResult;
        }

        // GET: api/Huts/5
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Hut))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Hut>> GetHut(int id)
        {
            var hut = await _context.Huts.FindAsync(id);

            if (hut == null)
            {
                return NotFound();
            }

            return hut;
        }

        // PUT: api/Huts/5
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Hut))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]        
        [HttpPut("{id}")]        
        public async Task<IActionResult> PutHut(int id, Hut hut)
        {
            if (id != hut.Id)
            {
                return BadRequest();
            }

            _context.Entry(hut).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HutExists(id))
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

        // POST: api/Huts
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(Hut))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpPost]
        public async Task<ActionResult<Hut>> PostHut(Hut hut)
        {
            //if (ModelState.IsValid)
            //{
            //    return BadRequest();
            //}
            _context.Huts.Add(hut);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHut", new { id = hut.Id }, hut);
        }

        // DELETE: api/Huts/5
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Hut))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hut>> DeleteHut(int id)
        {
            var hut = await _context.Huts.FindAsync(id);
            if (hut == null)
            {
                return NotFound();
            }

            _context.Huts.Remove(hut);
            await _context.SaveChangesAsync();

            return hut;
        }

        private bool HutExists(int id)
        {
            return _context.Huts.Any(e => e.Id == id);
        }
    }
}
