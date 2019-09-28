using AppService.Core.Shared;

namespace AppService.Models
{
    public class Superhero : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
