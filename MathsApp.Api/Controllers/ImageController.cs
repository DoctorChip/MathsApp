using MathsApp.Api.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MathsApp.Api.Controllers
{
    [Route("api")]
    [Authorize]
    public class ImageController : Controller
    {
        private readonly IImageService imageService;

        public ImageController(IImageService imageService)
        {
            this.imageService = imageService;
        }

        [HttpGet("image")]
        public async Task<string> GetImageString()
        {
            return "Hello World!";
        }
    }
}