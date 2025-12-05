using Catalogo.Domain.Abstractions;
using Catalogo.Domain.Categories.Events;

namespace Catalogo.Domain.Categories
{
    public class Category : Entity
    {
        public string Name { get; private set; } = null!;
        private Category(Guid id, string name) : base(id)
        {
            Name = name;
        }

        public static Category Create(string name)
        {
            var category = new Category(Guid.NewGuid(), name);
            var categoryDominEvent = new CategoryCreatedDomainEvent(category.Id);
            category.RaiseDomainEvent(categoryDominEvent);

            return category;
        }
    }
}
