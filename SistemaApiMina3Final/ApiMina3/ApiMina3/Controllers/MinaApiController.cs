using ApiMina3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiMina3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinaApiController : ControllerBase
    {
        private readonly TodoContext _context;

        public MinaApiController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<eqt_real_time>>> GetSuaTabela() //MinaApi
        {
            return await _context.Eqt_real_time.ToListAsync(); //todo item
        }

    }
}
