using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClientesAPI.Data;
using System.Threading.Tasks;

namespace ClientesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClientesContext _context;

        public ClientesController(ClientesContext context)
        {
            _context = context;
        }

        [HttpGet("sp")]
        public async Task<IActionResult> GetClientesPaginados(int pageNumber = 1, int pageSize = 10)
        {
            var clientes = await _context.GetClientesPaginados(pageNumber, pageSize);
            return Ok(clientes);
        }

        [HttpGet("ef")]
        public async Task<IActionResult> GetClientesPaginadosEF(int pageNumber = 1, int pageSize = 10)
        {
            var clientes = await _context.Clientes
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return Ok(clientes);
        }
    }
}
