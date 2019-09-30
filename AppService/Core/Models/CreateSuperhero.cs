using AppService.Models;
using Microsoft.AspNetCore.Http;

namespace AppService.Core.Models
{
    public class CreateSuperhero : Superhero
    {
        public IFormFile File { get; set; }
    }
}