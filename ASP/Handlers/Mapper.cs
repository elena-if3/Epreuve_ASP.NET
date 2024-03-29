﻿using ASP.Models;
using BLL.Entities;

namespace ASP.Handlers
{
    public static class Mapper
    {
        #region Category
        public static CategoryListItemViewModel ToListItem(this Category entity)
        {
            if (entity is null) return null;
            return new CategoryListItemViewModel()
            {
                Cat_Id = entity.Cat_Id,
                CatName = entity.CatName,
                //CatDescr = entity.CatDescr
            };
        }

        public static CategoryDetailsViewModel ToDetails(this Category entity)
        {
            if (entity is null) return null;
            return new CategoryDetailsViewModel()
            {
                Cat_Id = entity.Cat_Id,
                CatName = entity.CatName,
                CatDescr = entity.CatDescr,
            };
        } 
        #endregion
        #region Product
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

        public static ProductEditForm Update(this Product entity)
        {
            if (entity is null) return null;
            return new ProductEditForm()
            {
                Product_Id = entity.Product_Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                Category_Id = entity.Category_Id,
                EcoScore = entity.EcoScore
            };
        }

        public static Product ToBLL(this ProductEditForm entity)
        {
            if (entity is null) return null;
            return new Product(
                entity.Product_Id,
                entity.Name,
                entity.Description,
                entity.Price,
                entity.Category_Id,
                entity.EcoScore
                );
        }

        public static ProductDeleteViewModel Delete(this Product entity)
        {
            if (entity is null) return null;
            return new ProductDeleteViewModel()
            {
                Product_Id = entity.Product_Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                Category_Id = entity.Category_Id,
                EcoScore = entity.EcoScore
            };
        } 
        #endregion
        public static Media ToBLL(this MediaCreateForm entity)
        {
            if (entity is null) return null;
            return new Media(
                entity.Photo.FileName,
                entity.Product_Id
                );
        }
    }
}
