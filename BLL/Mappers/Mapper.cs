using System;
using BLL.Entities;

namespace BLL.Mappers
{
    internal static class Mapper
    {
        public static Product ToBLL(this DAL.Entities.Product entity)
        {
            if (entity is null) return null;
            return new Product(
                entity.Product_Id,
                entity.Name,
                entity.Description,
                entity.Price,
                entity.Category_Id,
                Enum.Parse<EcoScores>(entity.EcoScore)
                );
        }

        public static DAL.Entities.Product ToDAL(this Product entity)
        {
            if (entity is null) return null;
            return new DAL.Entities.Product()
            {
                Product_Id = entity.Product_Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                Category_Id = entity.Category_Id,
                EcoScore = entity.EcoScore.ToString()
            };
        }
    }
}
