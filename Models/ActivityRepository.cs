using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models
{
    public class ActivityRepository
    {
        public static Activity GetActivity(int iD)
        {
            Activity activity = null;
            string sql = $"SELECT * FROM Activites WHERE Id ={id}";
            DB.OpenConnection();
            var reader= DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                activity = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return activity;
        }
        public static List<Activity> GetActivities()
        {
            Activity =new List<Activity>(); 

            return Activity;

            string sql= "Select * FROM activities"
                DB.OpenConnection
                var reader= DB.GetDataReader(sql);
            while(reader.read)
            {
                Activity activity = CreateObject(reader);
                activites.add(activity);

            }
            reader.close();
            DB.CloseConnection
        }
        private static Activity CreateObject(System.Data.SqlClient.SqlDataReader reader)
        {
            int iD= int.Parse(reader["iD"].ToString())
            string name= reader["Name"].ToString();
            string description= reader["Description"].ToString();
            int maxpoints= int.Parse(reader["MaxPoints"].ToString());
            int minpointforgrade = int.Parse(reader["Minpointforgraede"].ToString());
            int minpointsforsignature = int.Parse(reader["minpointoforig"].ToString());

            var activity = new Activity()
            {
                id = iD,
                name = name,
                description = description,
                maxpoints = maxpoints,
                minpoints = minpointsforsignature,
                minpointsforgraed = minpointforgrade
            };
            return activity;    
        }
    }
}
