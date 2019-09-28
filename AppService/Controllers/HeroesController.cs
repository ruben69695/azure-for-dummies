using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppService.Core.Interfaces;
using AppService.Models;
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
        public async Task<IActionResult> Post([FromBody]Superhero hero)
        {
            await _heroRepo.UpdateAsync(hero);
            return Ok();
        }
    }
}