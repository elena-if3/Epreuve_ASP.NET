using DAL.Entities;
using System.Data;
using System.Xml;

namespace DAL.Mappers
{
    public static class Mapper
    {
        public static Category ToCategory(this IDataRecord record)
        {
            if (record is null) return null;
            return new Category()
            {
                Cat_Id = (int)record["Cat_Id"],
                CatName = (string)record["CatName"],
                CatDescr = (string)record["CatDescr"]
            };
        }

        public static Media ToMedia(this IDataRecord record)
        {
            if (record is null) return null;
            return new Media()
            {
                Media_Id = (int)record["Media_Id"],
                Link = (string)record["Link"],
                Product_Id = (int)record["Product_Id"]
            };
        }

        public static PartialOrder ToPartialOrder(this IDataRecord record)
        {
            if (record is null) return null;
            return new PartialOrder()
            {
                Id = (int)record["Id"],
                Product_Id = (int)record["Product_Id"],
                Amount = (int)record["Amount"]
            };
        }

        public static Product ToProduct(this IDataRecord record)
        {
            if (record is null) return null;
            return new Product()
            {
                Product_Id = (int)record["Product_Id"],
                Name = (string)record["Name"],
                Description = (string)record["Description"],
                Price = (double)record["Price"],
                Category = (string)record["Category"],
                EcoScore = (string)record["EcoScore"]
            };
        }
    }
}
