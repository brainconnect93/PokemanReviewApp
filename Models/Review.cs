namespace PokemanReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }

        // One to One Relationship

        public Reviewer Reviewer { get; set; }

        public Pokemon Pokemon { get; set; }
    }
}
