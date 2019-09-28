using System.Linq;
using System.Threading.Tasks;
using AppService.Core.Interfaces;
using AppService.Models;

namespace AppService.Core
{
    public static class RepositoryPopulator 
    {
        public static async Task<int> Populate(IRepository heroesRepository)
        {
            if (heroesRepository.GetAll<Superhero>().Count() >= 6) 
                return 0;

            await heroesRepository.CreateAsync(new Superhero {
                Name = "La masa Esteban",
                ImageUrl = "..."
            });

            await heroesRepository.CreateAsync(new Superhero {
                Name = "Capitán Peke",
                ImageUrl = "..."
            });

            await heroesRepository.CreateAsync(new Superhero {
                Name = "Iron Javi",
                ImageUrl = "..."
            });

            await heroesRepository.CreateAsync(new Superhero {
                Name = "Capitana Mejías",
                ImageUrl = "..."
            });

            await heroesRepository.CreateAsync(new Superhero {
                Name = "Sinior de la Guerra",
                ImageUrl = "..."
            });

            await heroesRepository.CreateAsync(new Superhero {
                Name = "Alfoooonsshh Thunder",
                ImageUrl = "..."
            });

            return heroesRepository.GetAll<Superhero>().Count();
        }
    }
}