using FirstWebApi.DataAccess;
using FirstWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestersController : Controller
    {
        private readonly TesterHubContext _context;

        public TestersController(TesterHubContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tester>>> GetTesters()
        {
            return await _context.Tester.ToListAsync();
        }

    }
}

