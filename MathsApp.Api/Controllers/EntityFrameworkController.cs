using MathsApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MathsApp.Api.Controllers
{
    [Route("EF")]
    [AllowAnonymous]
    public class EntityFrameworkController : Controller
    {
        private readonly ApplicationDbContext context;

        public EntityFrameworkController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("Migrate")]
        public async Task<IActionResult> MigrateAsync()
        {
            await context.Database.MigrateAsync();

            return Ok("Migrated");
        }
    }
}
