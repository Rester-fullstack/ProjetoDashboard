using DashboardAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DashboardAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly DashboardContext _context;

        public DashboardController(DashboardContext context)
        {
            _context = context;
        }

        [HttpGet("vendas")]
        public async Task<IActionResult> GetVendas()
        {
            var vendas = await _context.Vendas
                .OrderBy(v => v.DataVenda)
                .Select(v => new { dataVenda = v.DataVenda.ToString("yyyy-MM-dd"), v.Valor })
                .ToListAsync();

            return Ok(vendas);
        }

        [HttpGet("usuariosativos")]
        public async Task<IActionResult> GetUsuariosAtivos()
        {
            var usuarios = await _context.UsuariosAtivos
                .OrderBy(u => u.Data)
                .Select(u => new { data = u.Data.ToString("yyyy-MM-dd"), u.Quantidade })
                .ToListAsync();

            return Ok(usuarios);
        }
    }
}
