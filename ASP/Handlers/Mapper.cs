using ASP.Models;
using BLL.Entities;

namespace ASP.Handlers
{
    public static class Mapper
    {
        public static ProductListItemViewModel ToListItem(this Product entity)
        {
            if (entity is null) return null;
            return new ProductListItemViewModel()
            {
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                Category_Id = entity.Category_Id,
                EcoScore = entity.EcoScore
            };
        }
    }
}
