using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AppService.Core.Interfaces;
using AppService.Core.Models;
using AppService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppService.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        private readonly IRepository _heroRepo;
        public HeroesController(IRepository heroRepository)
        {
            _heroRepo = heroRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Superhero>> Get()
        {
            return await _heroRepo.GetAll<Superhero>()
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Superhero> Get(int id)
        {
            return await _heroRepo.GetAll<Superhero>()
                .FirstOrDefaultAsync(hero => hero.Id == id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Superhero hero) {
            hero.ImageUrl = Path.Combine("images", hero.ImageUrl);
            await _heroRepo.UpdateAsync(hero);
            return Ok();
        }

        [HttpPost("uploadImage")]
        public async Task<IActionResult> Post([FromForm]IFormFile file)
        {
            System.Console.WriteLine(file);
            string folderName = "wwwroot/images";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), folderName);

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            if (file != null && file.Length > 0) 
            {
                string finalDestination = Path.Combine(filePath, file.FileName);
                using (var stream =  new FileStream(finalDestination, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            return Ok();
        }
    }
}