using PokemanReviewApp.Models;

namespace PokemanReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        // Get & Read Method in API
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);

        // Post & Create Method in API
        bool CreateReviewer(Reviewer reviewer);

        // Put & Update Method In API
        bool UpdateReviewer(Reviewer reviewer);

        // Delete Method In API
        bool DeleteReviewer(Reviewer reviewer);
        bool Save();
        
    }
}
