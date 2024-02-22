using DAL.Entities;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DAL.Mappers;

namespace DAL.Services
{
    public class MediaService : BaseService, IMediaRepository<Media>
    {
        public MediaService(IConfiguration configuration) : base(configuration, "Database") { }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Media> Get()
        {
            throw new System.NotImplementedException();
        }

        public Media Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(Media data)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Media_Insert";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Link", data.Link);
                    cmd.Parameters.AddWithValue("Product_Id", data.Product_Id);
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void Update(Media data)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Media> GetByProduct (int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Media_GetByProduct";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Product_Id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToMedia();
                        }
                    }
                }
            }
        }
    }
}
