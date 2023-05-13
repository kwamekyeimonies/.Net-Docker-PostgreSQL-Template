using Demo.Microservices.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Demo.Microservices.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo.Microservices.Infrastructure.Controllers
{
    [ApiController]
    [Route("/api/demo-app")]

    public class DriversController : ControllerBase
    {
        private readonly ILogger<DriversController>? _logger;
        private readonly ApiDbContext _context;

        public DriversController(ILogger<DriversController> logger, ApiDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("drivers")]
        public async Task<IActionResult> GetAllDriversByAsync()
        {
            // var driver = new Driver()
            // {
            //     DriverNuber = 66,
            //     Name = "Prof.Tenkorang Daniel"
            // };

            // _context.Add(driver);
            // await _context.SaveChangesAsync();

            var allDrivers = await _context.Drivers.ToListAsync();

            return Ok(allDrivers);
        }
    }
}