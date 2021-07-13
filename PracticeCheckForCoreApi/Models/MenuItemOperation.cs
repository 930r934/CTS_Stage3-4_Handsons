using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PracticeCheckForCoreApi.Models
{
    public class MenuItemOperation
    {
        public static List<MenuItem> getallitems()
        {
            DbContext db = new DbContext();
            List<MenuItem> res = new List<MenuItem>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM menuitems", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Debug.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3}",
                        reader[0], reader[1], reader[2], reader[3]));

                        MenuItem item = new MenuItem();
                        item.Id = Int32.Parse(reader[0].ToString());
                        item.Name = reader[1].ToString();
                        item.Cousine = reader[2].ToString();
                        item.isveg = reader[3].ToString() == "0" ? false : true;
                        item.Calories = Int32.Parse(reader[4].ToString());
                        item.Price = Int32.Parse(reader[5].ToString());
                        res.Add(item);
                    }
                    conn.Close();
                }
            }
            return res;
        }

        public void Editwithid(int id, MenuItem json)
        {
            DbContext db = new DbContext();
            using (SqlConnection conn = db.GetConnection())
            {
                
                try
                {
                    conn.Open();
                    int setbit = 0;
                    if (json.isveg == true)
                        setbit = 1;
                    SqlCommand command = new SqlCommand($"update menuitems set name='{json.Name}',cousine ='{json.Cousine}',veg ={setbit}, calories ={json.Calories}, price ={json.Price} where id = {id}", conn);
                    var result = command.ExecuteNonQuery();
                    conn.Close();
                }
                catch
                {
                    Debug.WriteLine("00000000000 caught");
                }
                
            }
        }
    }
}
