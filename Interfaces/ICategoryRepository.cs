using PokemanReviewApp.Models;

namespace PokemanReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();

        // Get & Read Methods in API

        Category GetCategory(int id);
        ICollection<Pokemon> GetCategoryByPokemon(int categoryId);
        bool CategoryExists(int id);
    }
}
