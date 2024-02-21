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
                Product_Id = entity.Product_Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                Category_Id = entity.Category_Id,
                EcoScore = entity.EcoScore
            };
        }

        public static ProductDetailsViewModel ToDetails(this Product entity)
        {
            if (entity is null) return null;
            return new ProductDetailsViewModel()
            {
                Product_Id = entity.Product_Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                Category_Id = entity.Category_Id,
                EcoScore = entity.EcoScore
            };
        }

        public static Product ToBLL(this ProductCreateForm entity)
        {
            if (entity is null) return null;
            return new Product(
                0,
                entity.Name,
                entity.Description,
                entity.Price,
                entity.Category_Id,
                entity.EcoScore
                );
        }


    }
}
