using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace band_Business_I1
{
    public class QueryMaster
    {
        public static List<Band> GetBandData()
        {
            List<Band> bands = new List<Band>();
            using (var cn = new SqlConnection(@"Server=.\S2017E; User Id=band; Password=band;  Database=Band-Business")) //creating the variable and only letting it live in the braces
            {
                cn.Open();
                var sql = @"
                            select b.bandName, b.bandId, b.website, b.numberOfMembers
                            from Band b ";
                using (var cmd = new SqlCommand(sql, cn)) // creates scope for cmd
                {
                    // cmd.executeNonQuery(); 
                    // run a statement that you dont care about the results             
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            bands.Add(new Band()
                            {
                                bandName = (string)dr["bandName"],
                                bandId = (int)dr["bandId"], 
                                website = (string)dr["website"], 
                                numberOfMembers = (byte)dr["numMembers"]
                            });
                        }
                    }
                }
                cn.Close();
            }
            return bands;
        }


        public static List<Event> GetEventData()
        {
                   
            List<Event> events = new List<Event>();
            using (var cn = new SqlConnection(@"Server=.\S2017E; User Id=band; Password=band;  Database=Band-Business")) //creating the variable and only letting it live in the braces
            {
                cn.Open();
                var sql = @"
                            select b.bandName, b.bandId, b.website, b.numberOfMembers
                            from Band b ";
                using (var cmd = new SqlCommand(sql, cn)) // creates scope for cmd
                {
                    // cmd.executeNonQuery(); 
                    // run a statement that you dont care about the results             
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            categories.Add(new Band()
                            {
                                bandName = (string)dr["bandName"],
                                bandId = (int)dr["bandId"],
                                website = (string)dr["website"],
                                numberOfMembers = (byte)dr["numMembers"]
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
