using System;
using System.Linq;
using AppService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AppService.Infrastructure.Data
{
    public static class SeedData
    {
        public static readonly Superhero Esteban = new Superhero {
                Name = "La masa Esteban",
                Description = "Un ser especial, fuerte, trabajador y con una mente de programador genio loco y una experiencia equivalente a 400 chinos encerrados en un sótano. Cuando se cabrea mejor no estes delante porque podría ser tu último día en la tierra. Su frase favorita: \"Tan real como la vida misma\"",
                ImageUrl = "images/hulk.jpg"
        };

        public static readonly Superhero Ruben = new Superhero {
                Name = "Capitán Arrebola",
                Description = "El pequeño gran hombre único en su éspecie, una persona trabajadora y que le gusta ayudar a los demás, el problema es que es muy pesado. Apasionado en tirar lineas de código a diestro y siniestro. Su frase favorita: \"Awwwwacaaateee!!\"",
                ImageUrl = "images/captain-america.jpg"
        };

        public static readonly Superhero Javi = new Superhero {
                Name = "Iron Javi",
                Description = "El andaluz de hierro, un hombre duro y cuando le sale amable, mu trabajador pero con un caracter tan fuerte como el agua ardiente. Si fuera por el programarían en Java to kiski. Su frase favorita: \"Joooo sóc catalàh de neixament\"",
                ImageUrl = "images/iron-man.jpg"
        };

        public static readonly Superhero Virginia = new Superhero {
                Name = "Capitana Mejías",
                Description = "La capitana cálidad, una chica dura y peleona capaz de encontrarte bugs hasta en el carnet de identidad. Su frase favorita: \"Tengo hambre, necesito unos kikos\"",
                ImageUrl = "images/captain-marvel.jpg"
        };

        public static readonly Superhero Simo = new Superhero {
                Name = "Sinior de la Guerra",
                Description = "El guerrero Árabe un hombre que viene de tierras lejanas trabajador y honrado, esuvo una temporada entre melones y naranjas hasta que descubrió que la programación era su vida. Su frase favorita: \"¿Amohhh a comer?\"",
                ImageUrl = "images/war-machine.jpg"
        };

        public static readonly Superhero Alfons = new Superhero {
                Name = "Alfoooonsshh Thunder",
                Description = "Un hombre trabajador y de família, reciente pistolero de biberones. Bombero programador, dónde hay un fuego allí está para apagarlo. Descendiente del assessiino Altaïr de la época de las cruzadas (lo que pasa es que aún no lo sabe). Su frase favorita: \"¡Que pesados estos de Renfe...!\"",
                ImageUrl = "images/thor.png"
        };

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new AppServiceDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppServiceDbContext>>()))
            {
                // Look for any superhero items.
                if (dbContext.Heroes.Any())
                {
                    return;   // DB has been seeded
                }

                PopulateTestData(dbContext);
            }
        }

        public static void PopulateTestData(AppServiceDbContext dbContext)
        {
            foreach (var item in dbContext.Heroes)
            {
                dbContext.Remove(item);
            }

            dbContext.SaveChanges();
            dbContext.Heroes.Add(Esteban);
            dbContext.Heroes.Add(Ruben);
            dbContext.Heroes.Add(Javi);
            dbContext.Heroes.Add(Simo);
            dbContext.Heroes.Add(Virginia);
            dbContext.Heroes.Add(Alfons);

            dbContext.SaveChanges();
        }
    }
}