namespace Catalogo.Domain.Categories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
        void Add(Category category);
    }
}
