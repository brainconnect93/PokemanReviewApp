using PokemanReviewApp.Models;

namespace PokemanReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        // Get & Read Method in API
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);

        // Post & Create Method in API
        bool CreateReview(Review review);

        // Put & Update Method In API
        bool UpdateReview(Review review);
        bool Save();
    }
}
