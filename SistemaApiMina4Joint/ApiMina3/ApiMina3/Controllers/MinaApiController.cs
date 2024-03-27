using ApiMina3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
namespace ApiMina3.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class MinaApiController : ControllerBase
    {
        private readonly TodoContext _context;

        public MinaApiController(TodoContext context)
        {
            _context = context;
        }

        
        // GET: api/TodoItems
        [HttpGet("EQT_Real_Time")]
        public async Task<ActionResult<IEnumerable<eqt_real_time>>> GetSuaTabela() //MinaApi
        {
            return await _context.Eqt_real_time.ToListAsync(); //todo item
        }

       

        // GET: api/TodoItems
        [HttpGet ("Joint_EQT_Resources")]
        public async Task<ActionResult<IEnumerable<object>>> GetDuasTabelas()
        {
            var dados = await _context.Eqt_real_time
                .Join(_context.Resource,
                    t1 => t1.state_image_id,   // Chave comum na Tabela1
                    t2 => t2.id,   // Chave comum na Tabela2
                    (t1, t2) => new { Tabela1 = t1, Tabela2 = t2 })  // Resultado do join
                .ToListAsync();

            return dados;
        }


    }
}
