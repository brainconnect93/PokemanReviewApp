namespace PokemanReviewApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Many to Many Relationship
        public ICollection<PokemonCategory> pokemonCategories { get; set; }
    }
}
