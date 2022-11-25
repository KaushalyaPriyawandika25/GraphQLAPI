using System.ComponentModel.DataAnnotations;
namespace GraphQLAPI.Models
{
    public class UpdateSuperHero
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Height { get; set; }
    }
}
