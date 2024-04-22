namespace PokemanReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }

        // One to One Relationship
        public Country Country { get; set; }

        // Many to Many Relationship
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
