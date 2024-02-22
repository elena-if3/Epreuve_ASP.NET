using System;
using BLL.Entities;

namespace BLL.Mappers
{
    internal static class Mapper
    {
        #region Category
        public static Category ToBLL(this DAL.Entities.Category entity)
        {
            if (entity is null) return null;
            return new Category(
                entity.Cat_Id,
                entity.CatName,
                entity.CatDescr
                );
        }

        public static DAL.Entities.Category ToDAL(this Category entity)
        {
            if (entity is null) return null;
            return new DAL.Entities.Category()
            {
                Cat_Id = entity.Cat_Id,
                CatName = entity.CatName,
                CatDescr = entity.CatDescr
            };
        } 
        #endregion
        #region Product
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
        #endregion
        #region Media
        public static Media ToBLL(this DAL.Entities.Media entity)
        {
            if (entity is null) return null;
            return new Media(
                entity.Media_Id,
                entity.Link,
                entity.Product_Id
                );
        }

        public static DAL.Entities.Media ToDAL(this Media entity)
        {
            if (entity is null) return null;
            return new DAL.Entities.Media()
            {
                Media_Id = entity.Media_Id,
                Link = entity.Link,
                Product_Id = entity.Product_Id
            };
        } 
        #endregion
    }
}
