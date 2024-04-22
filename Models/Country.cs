namespace PokemanReviewApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // One to Many Relationship
        public ICollection<Owner> Owners { get; set; }
    }
}
