using DAL.Entities;
using System.Data;

namespace DAL.Mappers
{
    public static class Mapper
    {
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
