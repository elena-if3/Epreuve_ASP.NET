using DAL.Entities;
using DAL.Mappers;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Services
{
    public class ProductService : BaseService, IProductRepository<Product>
    {
        public ProductService(IConfiguration configuration) : base(configuration, "Database")
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Product_Delete";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Product_Id", id);
                    conn.Open();
                    if (cmd.ExecuteNonQuery() <= 0) throw new ArgumentException(nameof(id), $"The id #{ id } does not exist in the database.");
                }
            }
        }

        public IEnumerable<Product> Get()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Product_GetAll";
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduct();
                        }
                    }
                }
            }
        }
        public Product Get(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Product_GetById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Product_Id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToProduct();
                        throw new ArgumentException(nameof(id), $"The id #{ id } does not exist in the database.");
                    }
                }
            }
        }

        public int Insert(Product data)
        {
            using (SqlConnection conn = new SqlConnection( _connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Product_Insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Name", data.Name);
                    cmd.Parameters.AddWithValue("Description", data.Description);
                    cmd.Parameters.AddWithValue("Price", data.Price);
                    cmd.Parameters.AddWithValue("Category", data.Category);
                    cmd.Parameters.AddWithValue("EcoScore", data.EcoScore);
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void Update(Product data)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Product_Update";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Product_Id", data.Product_Id);
                    cmd.Parameters.AddWithValue("Name", data.Name);
                    cmd.Parameters.AddWithValue("Description", data.Description);
                    cmd.Parameters.AddWithValue("Price", data.Price);
                    cmd.Parameters.AddWithValue("Category", data.Category);
                    cmd.Parameters.AddWithValue("EcoScore", data.EcoScore);
                    conn.Open();
                    if (cmd.ExecuteNonQuery() <= 0) throw new ArgumentException(nameof(data.Product_Id), $"The id #{ data.Product_Id } does not exist in the database.");
                }
            }
        }

        //public IEnumerable<Product> GetByCategory()

    }
}
