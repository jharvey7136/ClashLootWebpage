using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClashLootWebpage.Models
{
    public class LootDBHandle
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["LootConnectionStr"].ToString();
            con = new SqlConnection(constring);
        }

        // **************** ADD NEW RECORD *********************
        public bool AddRecord(LootModel smodel)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddNewRecord", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dateNow", smodel.dateNow);
            cmd.Parameters.AddWithValue("@gold", smodel.Gold);
            cmd.Parameters.AddWithValue("@elixer", smodel.Elixer);
            cmd.Parameters.AddWithValue("@dark", smodel.Dark);
            cmd.Parameters.AddWithValue("@trophies", smodel.Trophies);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // ********** VIEW LOOT RECORDS ********************
        public List<LootModel> GetRecords()
        {
            connection();
            List<LootModel> recordlist = new List<LootModel>();

            SqlCommand cmd = new SqlCommand("GetRecords", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                recordlist.Add(
                    new LootModel
                    {
                        Id = (int)(dr["Id"]),
                        dateNow = (DateTime)dr["dateNow"],
                        Gold = (int)dr["gold"],
                        Elixer = (int)dr["elixer"],
                        Dark = (int)dr["dark"],
                        Trophies = (int)dr["trophies"]
                    });
            }
            return recordlist;
        }

        // ***************** UPDATE STUDENT DETAILS *********************
        public bool UpdateRecord(LootModel smodel)
        {
            connection();
            SqlCommand cmd = new SqlCommand("UpdateLootRecord", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dateNow", smodel.dateNow);
            cmd.Parameters.AddWithValue("@gold", smodel.Gold);
            cmd.Parameters.AddWithValue("@elixer", smodel.Elixer);
            cmd.Parameters.AddWithValue("@dark", smodel.Dark);
            cmd.Parameters.AddWithValue("@trophies", smodel.Trophies);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // ********************** DELETE LOOT RECORD *******************
        public bool DeleteRecord(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("DeleteRecord", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}