/* Jacob Ivey
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {
        public SqlProductDatabase(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override Product AddCore(Product product)
        {
            using (var conn = CreateConnection())
            using (var cmd = new SqlCommand("AddProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var parmName = new SqlParameter("@name", product.Name);
                cmd.Parameters.Add(parmName);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

                conn.Open();
                var result = (decimal)cmd.ExecuteScalar();
                product.Id = Convert.ToInt32(result);

                return product;
            };
        }

        protected override IEnumerable<Product> GetAllCore()
        {
            var ds = new DataSet();

            using (var conn = CreateConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "GetAllProducts";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    var da = new SqlDataAdapter()
                    {
                        SelectCommand = cmd
                    };

                    da.Fill(ds);
                };
            };

            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if (table != null)
            {
                foreach (var row in table.Rows.OfType<DataRow>())
                {
                    var product = new Product()
                    {
                        Id = (int)row[0],
                        Name = row["Name"] as string,
                        Description = row.Field<string>("Description"),
                        Price = row.Field<decimal>("Price"),
                        IsDiscontinued = row.Field<bool>("IsDiscontinued"),
                    };

                    yield return product;
                };
            };
        }

        protected override Product GetByNameCore(string name) 
        {
            using (var conn = CreateConnection())
            using (var cmd = new SqlCommand("FindByName", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var priceIndex = reader.GetOrdinal("Price");
                        var isDiscontinuedIndex = reader.GetOrdinal("IsDiscontinued");

                        var product = new Product()
                        {
                            Id = (int)reader[0],
                            Name = reader["Name"] as string,
                            Description = !reader.IsDBNull(3) ? reader.GetString(3) : "",
                            Price = reader.GetDecimal(priceIndex),
                            IsDiscontinued = reader.GetBoolean(isDiscontinuedIndex)
                        };

                        return product;
                    };
                };
            };

            return null;
        }
        protected override Product GetCore(int id)
        {
            using (var conn = CreateConnection())
            using (var cmd = new SqlCommand("GetProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var priceIndex = reader.GetOrdinal("Price");
                        var isDiscontinuedIndex = reader.GetOrdinal("IsDiscontinued");

                        var product = new Product()
                        {
                            Id = (int)reader[0],
                            Name = reader["Name"] as string,
                            Description = !reader.IsDBNull(3) ? reader.GetString(3) : "",
                            Price = reader.GetDecimal(priceIndex),
                            IsDiscontinued = reader.GetBoolean(isDiscontinuedIndex)
                        };

                        return product;
                    };
                };
            };

            return null;
        }
        protected override void RemoveCore(int id)
        {
            using (var conn = CreateConnection())
            using (var cmd = new SqlCommand("RemoveProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters[0].Value = id;

                conn.Open();
                cmd.ExecuteNonQuery();
            };
        }
        protected override Product UpdateCore(Product existing, Product newItem)
        {
            using (var conn = CreateConnection())
            using (var cmd = new SqlCommand("UpdateProduct", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var parmName = new SqlParameter("@name", newItem.Name);
                cmd.Parameters.Add(parmName);
                cmd.Parameters.AddWithValue("@id", newItem.Id);
                cmd.Parameters.AddWithValue("@description", newItem.Description);
                cmd.Parameters.AddWithValue("@price", newItem.Price);
                cmd.Parameters.AddWithValue("@isDiscontinued", newItem.IsDiscontinued);

                conn.Open();
                cmd.ExecuteNonQuery();

                return newItem;
            };
        }

        private SqlConnection CreateConnection()
        {
            var conn = new SqlConnection(_connectionString);
            return conn;
        }

        private string _connectionString;
    }
}
