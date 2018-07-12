using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class QueryMaster
    {
        public static List<Category> GetCategoryData()
        {
            List<Category> categories = new List<Category>();
            using (var cn = new SqlConnection(@"Server=.\S2017E; User Id=scott; Password=scott;  Database=sakila")) //creating the variable and only letting it live in the braces
            {
                cn.Open();
                var sql = @"
                            select c.name, c.category_id
                            from category c ";
                using (var cmd = new SqlCommand(sql, cn)) // creates scope for cmd
                {
                    // cmd.executeNonQuery(); 
                    // run a statement that you dont care about the results             
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            categories.Add(new Category()
                            {
                                categoryName = (string)dr["name"],
                                categoryId = (byte)dr["category_id"]
                            });
                        }
                    }
                }
                cn.Close();
            }
            return categories;
        }
    }
}
