using PokemanReviewApp.Models;

namespace PokemanReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();

        // Get & Read Methods in API
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int id);

        // Post & Create Methods in API
        bool CreateCategory(Category category);

        // Put & Update Methods in API
        bool UpdateCategory(Category category);

        // Delete Methods in API
        bool DeleteCategory(Category category);

        bool Save();
    }
}
