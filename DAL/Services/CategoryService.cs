using DAL.Entities;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DAL.Mappers;
using System;

namespace DAL.Services
{
    public class CategoryService : BaseService, ICategoryRepository<Category>
    {
        public CategoryService(IConfiguration configuration) : base(configuration, "Database")
        {
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Category> Get()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Category_GetAll";
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCategory();
                        }
                    }
                }
            }
        }

        public Category Get(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Category_GetById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Product_Id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToCategory();
                        throw new ArgumentException(nameof(id), $"The id #{id} does not exist in the database.");
                    }
                }
            }
        }

        public int Insert(Category data)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Category_Insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("CatName", data.CatName);
                    cmd.Parameters.AddWithValue("CatDescr", data.CatDescr);
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void Update(Category data)
        {
            throw new System.NotImplementedException();
        }
    }
}
