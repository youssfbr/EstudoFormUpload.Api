using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstudoFormUpload.API.Data;
using EstudoFormUpload.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EstudoFormUpload.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext _context { get; }
        public ValuesController(DataContext context)
        {
            this._context = context;
        }


        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get() // <IEnumerable<Evento>>
        {
            try
            {        
                var results = await _context.Eventos.ToListAsync();

                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "BD falhou");              
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
                try
                {
                    var results = await _context.Eventos.FirstOrDefaultAsync(x => x.EventoId == id);      

                    return Ok(results);
                }
                catch (System.Exception)
                {
                    return this.StatusCode(StatusCodes.Status500InternalServerError, "BD falou");                    
                }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
